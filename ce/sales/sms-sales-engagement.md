---
title: "Engage with customers through text messages"
description: "Enable your sellers to send text messages (SMS) to customers and refer previous communications in context without leaving the application or losing view of customers' details."
ms.date: 02/10/2023
ms.topic: overview
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Engage with customers through text messages

Sending text messages (SMS) is an effective way for sellers to reach out to potential customers as it is fast, convenient, and allows for quick responses. Also, sellers use SMS to stay in touch with their customers, by responding to questions or concerns, and providing updates and information on products/services.  
Now, Dynamics 365 Sales enables your sellers to send text messages (SMS) to communicate with customers through the SMS feature. Also, sellers can refer to their past communication in context without leaving the application or losing their view of their customers' details.   
In the sequences, the SMS can be included as a step to send reminders or updates about key events. More information: <cross-reference to SMS step in Add steps to define activities for sequences>

Depending on your role, you can use the SMS feature as described in the list:

-	System administrator or similar role:
    -	Configure the SMS provider in your organization for sellers to use. More information: [Configure SMS provider](configure-sms-provider.md)
    -	Assign or remove phone numbers to users.
- 	Sales manager, seller, or any other similar role: 
    -	Choose a service provider to send and receive SMS.
    -	Add SMS as a step in a sequence.
    -	Create and add SMS templates in sequence step.
    -	Send SMS from the Sales Accelerator workspace.
    -	Access past SMS interactions in context with relevant sales records such as lead and opportunity.

## Permissions required 

Review the following permissions required to use the SMS feature:

>[!NOTE]
>When Sales accelerator is enabled and security role are added to access Sales accelerator, no additional permission are required to using SMS features. To provide permissions in Sales accelerator, see [Sales accelerator first-run setup](enable-configure-sales-accelerator.md#first-run-setup) 

**For Salesperson or similar role**:<a name="salesperson-roles-sms-feature"></a>

| Tab name | Entity name | Access level | Privileges required |
|----------|-------------|--------------|---------------------|  
| Core Records | - Activity<br>- Note | User | - Create<br>- Write<br>- Delete<br>- Append |
| Core Records | - Activity<br>- Note | Business Unit | Read | 
| Custom Entities | Channel Instance | User | Append To |
| Custom Entities | - Channel Instance<br>- Channel Instance Account<br>- Consuming Application<br>- Channel Definition<br>- SalesOmnichannel Message<br>- Transcript | Business Unit | Read |
| Custom Entities | SalesOmnichannel Message | User | - Create<br>- Write<br>- Delete<br>- Append<br>- Assign |
| Custom Entities | Text message template | Business Unit | - Create<br>- Write<br>- Read<br>- Delete |
| Custom Entities | Transcript | User | - Create<br>- Write<br>- Delete<br>- Append<br>- Append To |

**For Sales Manager, Sequence Manage, or similar role**:

The following roles are required along with the roles defined in the [Salesperson section](#salesperson-roles-sms-feature):

| Tab name | Entity name | Access level | Privileges required |
|----------|-------------|--------------|---------------------|  
| Custom Entities | Channel Instance | Business Unit | - Assign<br>- Write |
| Custom Entities | - Channel Definition locale<br>- Telesign channel instance account<br>- Twilio channel instance account | Business Unit | Read |
| Custom Entities | - TeleSign channel instance<br>- Twilio channel instance | Business Unit | - Read<br>- Write<br>- Assign |


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Configure SMS provider](configure-sms-provider.md)

