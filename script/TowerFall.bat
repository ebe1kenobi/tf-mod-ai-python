@echo off

echo =============================================
echo =       EXECUTE TOWERFALL WITH PYTHON       =
echo =============================================

< NUL call config.bat

@REM prod path
cd %PYTHON_SCRIPT_PATH%
%REPO_DRIVE%

python run_simple_agent.py