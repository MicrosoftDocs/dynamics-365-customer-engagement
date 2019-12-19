All client-side code is initiated by events and the events occur in Dynamics 365 Unified Interface. You associate s specific function in a JavaScript library to execute when an event occurs. This specific function is called an *event handler*.

Each event handler specifies a function within a JavaScript library and the parameters that you can pass to the function. The JavaScript API provides methods that you can use to attach event handlers to the events.

## Events

**Version 1.0**

| Events | Description |
|---------|-------------|
| [onClickToAct](../reference/events/onClickToAct.md) | Invoked when user selects the outbound communication (ClickToAct) field in a form. |
| [onModeChanged](../reference/events/onModeChanged.md) | Invoked when the panel mode is manually toggled between **Minimized (0)**, **Docked (1)** and **Hidden (2)**. |
| [onPageNavigate](../reference/events/onPageNavigate.md) | Invoked when the main Unified Interface page navigation occurs. |
| [onSendKBArticle](../reference/events/onSendKBArticle.md) | Invoked when the user selects the **Send** button in the Knowledge Base control. |
| [onSizeChanged](../reference/events/onSizeChanged.md) | Invoked when the side panel width is changed. |
| [onSessionSwitched](../reference/events/onSessionSwitched.md) | Invoked when the session is switched. |
| [onSessionClosed](../reference/events/onSessionClosed.md) | Invoked when the session is closed. |

**Version 2.0**

| Events | Description |
|---------|-------------|
| [onClickToAct](../v2/reference/events/onClickToAct.md) | Invoked when user selects the outbound communication (ClickToAct) field in a form. |
| [onModeChanged](../v2/reference/events/onModeChanged.md) | Invoked when the panel mode is manually toggled between **Minimized (0)**, **Docked (1)** and **Hidden (2)**. |
| [onPageNavigate](../v2/reference/events/onPageNavigate.md) | Invoked when the main Unified Interface page navigation occurs. |
| [onSendKBArticle](../v2/reference/events/onSendKBArticle.md) | Invoked when the user selects the **Send** button in the Knowledge Base control. |
| [onSizeChanged](../v2/reference/events/onSizeChanged.md) | Invoked when the side panel width is changed. |
| [onSessionSwitched](../v2/reference/events/onSessionSwitched.md) | Invoked when the session is switched. |
| [onSessionClosed](../v2/reference/events/onSessionClosed.md) | Invoked when the session is closed. |