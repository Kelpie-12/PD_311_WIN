#undef UNICODE
#define _CRT_SECURE_NO_WARNINGS
#include <Windows.h>
#include "resource.h"
#include <iostream>
#include <Richedit.h>
#include <vector>
//17.06
CONST CHAR g_sz_WINDOW_CLASS[] = "TextEditorPD_311";
LPSTR FormatLastError();
INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
BOOL LoadTextFileToEdit(HWND& hEdit, LPCSTR lpszFileName);
BOOL SaveTextFileFromEdit(HWND hEdit, LPCSTR lpszFileName);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//AllocConsole();
	//freopen("CONOUT$", "w", stdout);
	WNDCLASSEX wc;
	ZeroMemory(&wc, sizeof(wc));

	wc.style = 0;
	wc.cbSize = sizeof(wc);
	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;

	wc.hIcon = (HICON)LoadImage(hInstance, "Icon\\Icon.ico", IMAGE_ICON, LR_DEFAULTSIZE, LR_DEFAULTSIZE, LR_LOADFROMFILE);
	wc.hIconSm = (HICON)LoadImage(hInstance, "Icon\\Icon.ico", IMAGE_ICON, LR_DEFAULTSIZE, LR_DEFAULTSIZE, LR_LOADFROMFILE);
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	wc.hbrBackground = (HBRUSH)/*(COLOR_WINDOW)*/CreatePatternBrush((HBITMAP)LoadImage(hInstance, "IMG\\text-typography.bmp", IMAGE_BITMAP, 0, 0, LR_LOADFROMFILE));

	wc.lpszClassName = g_sz_WINDOW_CLASS;
	wc.lpszMenuName = (LPSTR)IDR_MAIN_MENU;
	wc.lpfnWndProc = (WNDPROC)WndProc;
	wc.hInstance = hInstance;

	if (!RegisterClassEx(&wc))
	{
		MessageBox(NULL, "Class registation failed", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	HWND hwnd = CreateWindowEx
	(
		NULL,
		g_sz_WINDOW_CLASS,
		g_sz_WINDOW_CLASS,
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, CW_USEDEFAULT,
		CW_USEDEFAULT, CW_USEDEFAULT,
		NULL,
		NULL,
		hInstance,
		NULL
	);
	if (hwnd == NULL)
	{
		MessageBox(NULL, "Window creation failed", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	MSG msg;
	while (GetMessage(&msg, 0, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	//FreeConsole();
	return 0;
}
INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	static HINSTANCE richEd = LoadLibrary("RichEd20.dll");
	static CHAR lpszFileName[MAX_PATH]{};
	static BOOL FileSave = TRUE;
	static BOOL WordWrap = TRUE;
	switch (uMsg)
	{
	case WM_CREATE:
	{

		RECT windowRect;
		RECT clientRect;
		GetWindowRect(hwnd, &windowRect);
		GetClientRect(hwnd, &clientRect);
		HWND hEdit = CreateWindowEx
		(
			NULL, "RICHEDIT20A", "Workspace",
			WS_CHILD | WS_VISIBLE| ES_AUTOVSCROLL | ES_MULTILINE /**/ ,
			0, 0,
			windowRect.right - windowRect.left,
			windowRect.bottom - windowRect.top,
			hwnd,
			(HMENU)IDC_EDIT,
			NULL,
			NULL
		);

	}
	break;
	case WM_SIZE:
	{
		RECT window;
		GetClientRect(hwnd, &window);
		MoveWindow(GetDlgItem(hwnd, IDC_EDIT), 10, 10, window.right - window.left - 20, window.bottom - window.top - 20, TRUE);
	}
	break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case ID_FILE_OPEN:
		{
			OPENFILENAME ofn;
			ZeroMemory(&ofn, sizeof(ofn));
			ofn.lStructSize = sizeof(ofn);
			ofn.hwndOwner = hwnd;
			ofn.lpstrFilter = "Text files: (*.txt)\0*.txt\0All files (*.*)\0*.*\0";
			ofn.lpstrDefExt = "txt";
			ofn.nMaxFile = MAX_PATH;
			ofn.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY;
			ofn.lpstrFile = (LPSTR)lpszFileName;
			if (GetOpenFileName(&ofn))
			{
				HWND hEdit = GetDlgItem(hwnd, IDC_EDIT);
				FileSave = LoadTextFileToEdit(hEdit, lpszFileName);
			}
		}
		break;
		case ID_FILE_SAVE:
			if (strlen(lpszFileName))
				FileSave = SaveTextFileFromEdit(GetDlgItem(hwnd, IDC_EDIT), lpszFileName);
			else 
				SendMessage(hwnd, WM_COMMAND, ID_FILE_SAVEAS, 0);
			break;
		case ID_FILE_SAVEAS:
		{
			//CHAR szFileName[MAX_PATH]{};
			OPENFILENAME ofn;
			ZeroMemory(&ofn, sizeof(ofn));
			ofn.lStructSize = sizeof(ofn);
			ofn.hwndOwner = hwnd;
			ofn.lpstrFilter = "Text files: (*.txt)\0*.txt\0All files (*.*)\0*.*\0";
			ofn.lpstrDefExt = "txt";
			ofn.nMaxFile = MAX_PATH;
			ofn.Flags = OFN_EXPLORER | OFN_PATHMUSTEXIST | OFN_HIDEREADONLY|OFN_OVERWRITEPROMPT;
			ofn.lpstrFile = (LPSTR)lpszFileName;
			if (GetSaveFileName(&ofn))
			{				
				SaveTextFileFromEdit(GetDlgItem(hwnd, IDC_EDIT), lpszFileName);
			}
			auto d = GetLastError();
			int a = 10;

		}
		break;
		case ID_FORMAT_WORDWRAP:
		{
			CHAR* buffer[MAX_PATH]{};

			if (WordWrap)
			{			

				INT length =SendMessage(GetDlgItem(hwnd, IDC_EDIT), EM_GETLINECOUNT ,0,0);				
				std::vector<std::string> tmp;
				for (size_t i = 0; i < length; i++)
				{
					
					SendMessage(GetDlgItem(hwnd, IDC_EDIT), EM_GETLINE, (WPARAM)i, (LPARAM)buffer);
					auto f = GetLastError();
					int fd = 10 + 2;
					//std::string a = (CHAR)buffer;
					//tmp.push_back(a);
				}
				RECT windowRect;
				GetWindowRect(GetDlgItem(hwnd, IDC_EDIT), &windowRect);
				DestroyWindow(GetDlgItem(hwnd, IDC_EDIT));
				HWND hEdit = CreateWindowEx
				(
					NULL, "RICHEDIT20A", (LPCSTR)buffer,
					WS_CHILD | WS_VISIBLE | ES_MULTILINE | ES_AUTOVSCROLL | WS_VSCROLL,
					10, 10,
					windowRect.right - windowRect.left,
					windowRect.bottom - windowRect.top,
					hwnd,
					(HMENU)IDC_EDIT,
					NULL,
					NULL
				);
				//SendMessage(GetDlgItem(hwnd, IDC_EDIT), WM_PASTE, 0, 0);


			
				//SendMessage(GetDlgItem(hwnd, IDC_EDIT), EM_SETWORDBREAKPROC, 0, 0);
			
				
				WordWrap = FALSE;
			}
			else
			{
				RECT windowRect;
				GetWindowRect(GetDlgItem(hwnd, IDC_EDIT), &windowRect);
				int a = GetWindowTextLength(GetDlgItem(hwnd, IDC_EDIT));
				GetWindowText(GetDlgItem(hwnd, IDC_EDIT), (LPSTR)buffer, a);
				//SendMessage(GetDlgItem(hwnd, IDC_EDIT), WM_GETTEXT, MAX_PATH, (LPARAM)buffer);
				DestroyWindow(GetDlgItem(hwnd, IDC_EDIT));
				HWND hEdit = CreateWindowEx
				(
					NULL, "RICHEDIT20A", (LPCSTR)buffer,
					WS_CHILD | WS_VISIBLE ,
					10, 10,
					windowRect.right - windowRect.left,
					windowRect.bottom - windowRect.top,
					hwnd,
					(HMENU)IDC_EDIT,
					NULL,
					NULL
				);
				WordWrap = TRUE;
			}
		}
			break;
		default:
			break;
		}
		break;
	case WM_DESTROY:		
		PostQuitMessage(0);
		break;
	case WM_CLOSE:
		FreeLibrary(richEd);
		DestroyWindow(hwnd);
		break;
	default:
		return DefWindowProc(hwnd, uMsg, wParam, lParam);
		break;
	}
	return false;
}

BOOL LoadTextFileToEdit(HWND& hEdit, LPCSTR lpszFileName)
{
	BOOL bSuccess = FALSE;
	HANDLE hFile = CreateFile(lpszFileName, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, NULL, NULL);
	if (hFile != INVALID_HANDLE_VALUE)
	{
		DWORD dwFileSize = GetFileSize(hFile, NULL);
		if (dwFileSize != UINT_MAX)
		{
			LPSTR lpszFileText = (LPSTR)GlobalAlloc(GPTR, dwFileSize + 1);
			if (lpszFileText)
			{
				DWORD dwRead = 0;
				if (ReadFile(hFile, lpszFileText, dwFileSize, &dwRead, NULL))
				{
					if (SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)lpszFileText))
					{
						bSuccess = TRUE;
					}
				}
				GlobalFree(lpszFileText);
			}
			CloseHandle(hFile);
		}
	}
	return bSuccess;
}

BOOL SaveTextFileFromEdit(HWND hEdit, LPCSTR lpszFileName)
{
	BOOL bSuccess = FALSE;
	HANDLE hFile = CreateFile(lpszFileName, GENERIC_WRITE, NULL, NULL, CREATE_ALWAYS, FILE_ATTRIBUTE_NORMAL, NULL);
	if (hFile != INVALID_HANDLE_VALUE)
	{
		DWORD dwTextLength = SendMessage(hEdit, WM_GETTEXTLENGTH, 0, 0);
		if (dwTextLength > 0)
		{
			LPSTR lpszText = (LPSTR)GlobalAlloc(GPTR, dwTextLength);
			if (lpszText)
			{
				if (SendMessage(hEdit, WM_GETTEXT, dwTextLength + 1, (LPARAM)lpszText))
				{
					DWORD dwWritten;
					if (WriteFile(hFile, lpszText, dwTextLength, &dwWritten, NULL))
					{
						bSuccess = TRUE;
					}
					GlobalFree(lpszText);
				}
			}
		}
		CloseHandle(hFile);
	}
	return bSuccess;
}



LPSTR FormatLastError()
{
	DWORD dwErrorMessageID = GetLastError();	//Функция GetLastError() возвращает числовой код последней возникшей ошибки выполненя.
	LPSTR lpszMessageBuffer = NULL;
	DWORD dwSize = FormatMessage
	(
		FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
		NULL,
		dwErrorMessageID,
		MAKELANGID(LANG_NEUTRAL, SUBLANG_RUSSIAN_RUSSIA),
		(LPSTR)&lpszMessageBuffer,
		0,
		NULL
	);
	return lpszMessageBuffer;
}