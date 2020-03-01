using System;

namespace DistingLibraryManager.Models
{
    /// <summary>
    /// Represents a single sample, and the options applied in the playlist.
    /// </summary>
    /// <remarks>
    /// Some of these options require further explanation, for which I would refer you to the Disting Mk4 manual.
    /// </remarks>
    public class Sample
    {
        /// <summary>
        /// The name of the file the sample will be written to, without extension.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The path from where this sample will be read if conversion is applied.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// <c>true</c> if this sample represents a loop.
        /// </summary>
        public bool IsLoop { get; set; }

        /// <summary>
        /// The amount of fade in time.
        /// </summary>
        public TimeSpan FadeIn { get; set; }

        /// <summary>
        /// The amount of fade out time.
        /// </summary>
        public TimeSpan FadeOut { get; set; }

        /// <summary>
        /// The amount of gap time.
        /// </summary>
        public TimeSpan Gap { get; set; }

        /// <summary>
        /// <c>true</c> if the sample should trigger when selected.
        /// </summary>
        public bool RetriggerOnSampleChange { get; set; }

        /// <summary>
        /// When different from 0, sets a fixed playback speed.
        /// </summary>
        public float FixedPitch { get; set; }

        /// <summary>
        /// Sets the output of B. 
        /// </summary>
        public OutputBOptions OutputB { get; set; }

        /// <summary>
        /// Sets the number of pulses sent to output B. <see cref="OutputB" />.
        /// </summary>
        public int TriggerCount { get; set; }

        /// <summary>
        /// Sets the number of clocks for the duration of the sample, for clocked playback.
        /// </summary>
        public int ClockCount { get; set; }

        // Not doing WaveLength as it only applies to waveforms.

        /// <summary>
        /// Sets the "natural" MIDI note number for the sample.
        /// </summary>
        public int NaturalMidiNoteNumber { get; set; }

        /// <summary>
        /// Sets the "switch" MIDI note number for the sample.
        /// </summary>
        public int SwitchMidiNoteNumber { get; set; }

        /// <summary>
        /// If <c>true</c>, playback is not retriggered until sample has completed.
        /// </summary>
        public bool PlayToCompletion { get;set; }

        /// <summary>
        /// If <c>true</c>, the sample will start playing at the beginning if started without explicit trigger (i.e. on sample change)
        /// </summary>
        public bool UseStartOnSampleChange { get; set; }

        /// <summary>
        /// Number of quantized start points used for the sample for algorithms that support CV for the start position.
        /// </summary>
        public int StartQuantize { get; set; }
    }
}
