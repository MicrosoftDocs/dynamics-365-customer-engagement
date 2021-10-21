---
title: "Display custom context | MicrosoftDocs"
description: "Use this topic to understand how to display custom context in the Conversation summary section of conversations."
ms.date: 10/21/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Display custom context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The data type of the context variables is a JSON object with two properties&mdash;`isDisplayable` and `Value`. The input value for `isDisplayable` is **Boolean** (true or false). The input value for `Value` can be **Boolean**, **String**, or **Number**. The JSON object has the following schema.

```JavaScript
{
            "type": "object",
             "properties": {
                    "isDisplayable": {
                        " description": " Context variable should display in agent UI or not",
                        "type": "boolean"
                    },
                    "Value": {
                         " description": " Context variable value pass through bot , this can be string Boolean or number",
                        "type": "string or Boolean or Number"
                    }
                },
                "required": [ "isDisplayable", "Value" ]            
        }

```

Here's an example of the `isDisplayable` attribute:
`{\"isDisplayable\":\"true\"," +"\"Value\":\"context variable value as string\"}`

To display the context variables in the [Conversation Summary Control of conversations](oc-customer-summary.md#conversation-summary) for Power Virtual Agents and Azure bots, use the `isDisplayable` property in the body of [setContextProvider](developer/reference/methods/setContextProvider.md) method.

The `isDisplayable` property, when set to `true`, will display the context variables in the third tab on the Conversation Summary Control for a given conversation. The `Value` property includes the user response or any other information in string, Boolean, or number format.

![Display context keys.](media/context-variable-display.png "Display context keys")


### See also

[Manage custom context](send-context-starting-chat.md)<br />
[setContextProvider](developer/reference/methods/setContextProvider.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
