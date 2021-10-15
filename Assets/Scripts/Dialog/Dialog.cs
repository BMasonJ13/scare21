/* Benton Justice
 * 10/14/2021
 * Dailog Implementation
 */

using UnityEngine;

namespace Scare.Dialog
{
    [CreateAssetMenu(fileName = "New Dialog", menuName = "Dialog Data", order = 1)]
    public class Dialog : ScriptableObject
    {
        [SerializeField]
        private string _dialogText;

        /// <summary>
        /// Text for the dialog. Used for captions.
        /// </summary>
        public string DialogText { get { return _dialogText; } }

        [SerializeField]
        [ColorUsage(true, true)]
        private Color _dialogColor;

        /// <summary>
        /// The color of the text. Color is HDR.
        /// </summary>
        public Color DialogColor { get { return _dialogColor; } }

        [SerializeField]
        private AudioClip _dialogAudio;

        /// <summary>
        /// Audio clip for the dialog.
        /// </summary>
        public AudioClip DialogAudio { get { return _dialogAudio; } }

        [SerializeField]
        private float _delay;

        /// <summary>
        /// Delay before starting the AudioClip.
        /// </summary>
        public float Delay { get { return _delay; } }

        [SerializeField]
        private Dialog _next;
        /// <summary>
        /// The next logical Dialog Node in the Dialog chain. Null if dialog chain has ended.
        /// </summary>
        public Dialog Next { get { return _next; } }

    }
}
