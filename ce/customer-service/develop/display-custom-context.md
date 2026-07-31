---
title: Display custom context in Conversation summary
description: Learn how to display custom context variables in the Conversation summary control for conversations.
ms.date: 07/31/2026
ms.topic: reference
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
---

# Display custom context in Conversation summary

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

The data type of the context variables is a JSON object with two properties: **isDisplayable** and **Value**.

The JSON object has the following schema:

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

The input value for **isDisplayable** is:

- **Boolean** (true or false)

The input value for **Value** can be:
- **Boolean**
- **String**
- **Number**

To display the context variables in the [Conversation Summary Control of conversations](../use/oc-customer-summary.md#view-conversation-summary) for Copilot Studio and Azure bots, use the `isDisplayable` property in the body of [setContextProvider](reference/methods/setContextProvider.md) method.

Example:
`{\"isDisplayable\":\"true\"," +"\"Value\":\"context variable value as string\"}`

The input value for isDisplayable is a Boolean value (true or false). The input value for Value can be a string, Boolean value, or number.

To display context variables in the ../use/oc-customer-summary.md#view-conversation-summary for conversations that use Microsoft Copilot Studio or Azure bots, include the `isDisplayable` property in the body of the reference/methods/setContextProvider.md method.

The following example displays a string context variable:

{
  "isDisplayable": true,
  "Value": "Context variable value"
}

When **isDisplayable** is set to true, the context variable appears on the third tab of the Conversation Summary control. The Value property contains the user's response or other information in string, Boolean, or number format.

:::image type="content" source="../media/context-variable-display.png" alt-text="Conversation Summary control displaying custom context variables." :::

## Related information

[Send custom context](send-context-starting-chat.md)  
[setContextProvider](reference/methods/setContextProvider.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
