
@REM kill process towerfall if exists
@REM taskkill /IM TowerFall.exe
@rem "C:\Program Files (x86)\Steam\steamapps\common\TowerFall\TowerFall.exe"
@rem timeout 5
@REM cd D:\__dev\code\towerfall-ai-myfork\script
@REM d:
< NUL call config.bat
cd %PYTHON_SCRIPT_PATH%
%REPO_DRIVE%

@REM cd D:\__dev\code\towerfall-ai-myfork
@REM d:
python run_simple_agent_show_agent_movement.py
pause
@rem cmd /k