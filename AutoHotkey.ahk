#Persistent
#SingleInstance Force
; Define the hotkey Ctrl + Shift + C
~LWin::
    Clipboard := ""
    Send, ^c
    ClipWait, 4
    selectedText := Clipboard
    StringReplace, selectedText, selectedText, `r`n, %A_Space%, All
    StringReplace, selectedText, selectedText, `n, %A_Space%, All
    StringReplace, selectedText, selectedText, `t, %A_Space%, All
    filePath := "C:\Audio\The Ultimate Resource RU\Test.txt"
    FileAppend, %selectedText%`r`n, %filePath%, UTF-8
return
