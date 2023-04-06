---
title: "Display custom context | MicrosoftDocs"
description: "Use this topic to understand how to display custom context in the Conversation summary section of conversations."
ms.date: 10/21/2021
ms.topic: reference
author: lalexms
ms.author: laalexan
---
# Display custom context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The data type of the context variables is a JSON object with two properties&mdash;`isDisplayable` and `Value`. The JSON object has the following schema.

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

The input value for `isDisplayable` is **Boolean** (true or false). The input value for `Value` can be **Boolean**, **String**, or **Number**.

To display the context variables in the [Conversation Summary Control of conversations](oc-customer-summary.md#view-conversation-summary) for Power Virtual Agents and Azure bots, use the `isDisplayable` property in the body of [setContextProvider](developer/reference/methods/setContextProvider.md) method.

Here's an example:
`{\"isDisplayable\":\"true\"," +"\"Value\":\"context variable value as string\"}`

The `isDisplayable` property, when set to `true`, will display the context variables on the third tab of the Conversation Summary Control for a conversation. The `Value` property of the JSON object includes the user response or any other information in string, Boolean, or number format.

![Display context keys.](media/context-variable-display.png "Display context keys")


### See also

[Send custom context](send-context-starting-chat.md)<br />
[setContextProvider](developer/reference/methods/setContextProvider.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
