﻿#if !USE_OPENAI

using UnityEngine;
using UnityEditor;

namespace PixelCrushers.DialogueSystem.DialogueEditor
{

    /// <summary>
    /// Default DrawAI* method implementations when not using an AI content generation addon.
    /// These implementations draw nothing.
    /// </summary>
    public partial class DialogueEditorWindow
    {

        private bool DrawAIDatabaseFoldout(bool foldout)
        {
            return foldout;
        }

        public void OpenTranslateDatabasePanel()
        {
        }

        private void DrawAIGenerateConversationButton()
        {
        }

        private void DrawAIReviseTextButton(Asset asset, DialogueEntry entry, Field field)
        {
        }

        private void DrawAILocalizeTextButton(Asset asset, DialogueEntry entry, Field field)
        {
        }

    }
}
#endif