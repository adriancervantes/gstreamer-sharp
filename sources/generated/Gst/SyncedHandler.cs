// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;

	public delegate void SyncedHandler(object o, SyncedArgs args);

	public class SyncedArgs : GLib.SignalArgs {
		public bool Synced{
			get {
				return (bool) Args [0];
			}
		}

	}
}
