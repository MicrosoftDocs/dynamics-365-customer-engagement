Dynamics 365 Channel Integration Framework 2.0 supports the following modes.

## Docked

The docked mode is the default mode of the communication widget, where it's placed between the session panel and the application tab panel.

## Minimized

The minimized mode is an overlay mode where the communication widget is reduced to a smaller size to give agents more screen space to view the applications. 

This is useful for agents who have started talking to the customer and need only minimal actions (for example, hold and mute) on the communication widget and thus can use the space to view more info on the application tab panel.

## Hidden

The communication panel isn't visible, but the communication widget code is running in the background.

An agent can manually switch the mode from docked to minimized and vice versa.

Providers can switch the mode using APIs.

Providers can also decide on the mode of the communication widget when they're starting a session.

## Collapsed

The communication panel is visible by default. Agents can collapse the panel manually.

Providers can collapse the panel using APIs.