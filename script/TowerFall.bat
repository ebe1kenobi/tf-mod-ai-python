@echo off

echo =============================================
echo =       EXECUTE TOWERFALL WITH PYTHON       =
echo =============================================

< NUL call config.bat

@REM prod path
cd %TOWERFALL_PYTHON_PATH%
%GAME_DRIVE%

python run_simple_agent.py