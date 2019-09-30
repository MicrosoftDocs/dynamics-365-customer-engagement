# Events

Channel Integration Framework version 2.0 release introduces the following out-of-box events:

**Session Events**

- **Session end**

Event name: onSessionClosed

Invoked by the client when a session is closed. This handler will pass the sessionClosed message to the widget as an event resulting in the registered widget-side handler, if any, being invoked.

- **Session switched**

Event name: onSessionSwitched

Invoked by the client when a session is switched. This handler will pass the sessionSwitch message to the widget as an event resulting in the registered widget-side handler, if any, being invoked.

