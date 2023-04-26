#SingleInstance Force					; prevents multiple instances of script

if not WinExist("ahk_class Turbine Device Class")	; if DDO not open don't do the rest
{
	MsgBox, DDO not open why are you like this	; error message
	ExitApp						; pls get me out
	return
}
else							; if DDO is open
{
	WinActivate ahk_class Turbine Device Class 	; activates DDO
	Sleep 250					; wait a lil 
	Send !{enter}					; enter windowed to fix graphics errors
	Sleep 250					; wait a lil 
	Send !{enter}					; exit windowed to return to where you were
	Sleep 250					; wait a lil 
	oldClip := clipboard                            ; save your current clipboard data to a variable to set it back later
	clipboard = /alias clearlist                    ; clears existing aliases
	Send {enter}                              	; hit Enter to open chat
	Send ^v						; paste clipboard
	Sleep 250					; wait a lil 					
	Send {enter}					; hit Enter to send command in DDO
	clipboard = /UI layout load DASLayout    	; put the UI update string into your clipboard
	Sleep 250					; wait a lil 				
	Send {enter}                              	; hit Enter to open chat
	Send ^v						; paste clipboard
	Sleep 250					; wait a lil 
	Send {enter}					; hit Enter to send command in DDO
	Clipboard := oldclip				; puts your old clipboard back
	Oldclip := ""					; clears the variable for memory purposes
	ExitApp						; kills this program
}
ExitApp							; dieeeee
return					

Esc::         						; Escape closes this but you shouldn't ever get here
ExitApp
Return

