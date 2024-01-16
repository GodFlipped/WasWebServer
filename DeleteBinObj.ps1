Get-ChildItem . -Recurse | Where-Object {$_.Name -match ".*(bin|obj)$"} | Remove-Item -Recurse -Force
