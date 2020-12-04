﻿namespace Kalk.Core
{
    public enum KalkAction
    {
        CopySelectionOrExit,
        Exit,
        CursorLeft,
        CursorRight,
        CursorLeftWord,
        CursorRightWord,
        CursorStartOfLine,
        CursorEndOfLine,
        HistoryPrevious,
        HistoryNext,
        DeleteCharacterLeft,
        DeleteCharacterLeftAndCopy,
        DeleteCharacterRight,
        DeleteCharacterRightAndCopy,
        DeleteWordLeft,
        DeleteWordRight,
        Completion,
        DeleteTextRightAndCopy,
        DeleteWordRightAndCopy,
        DeleteWordLeftAndCopy,
        CopySelection,
        CutSelection,
        PasteClipboard,
        ValidateLine,
        ForceValidateLine,
    }
}