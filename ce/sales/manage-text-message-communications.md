---
title: "Manage text message conversations"
description: "Manage customer conversations through incoming and outgoing text messages for your sales outreach."
ms.date: 02/10/2023
ms.topic: conceptual
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Manage text message conversations (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

You can manage customer conversations through incoming and outgoing text messages as a part of your sales outreach.   

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

Before you start using the inbound text message feature, verify that the following prerequisites are met:

- The text message feature is enabled with the callback URL configured in your SMS provider settings to receive incoming (replies) messages. For more information on callback URL, see step 4 in [Set up the SMS provider in Dynamics 365 Sales](configure-sms-provider.md#set-up-the-sms-provider-in-dynamics-365-sales).

- Contact your administrator to enable the **In-app notifications** option in [Power Apps portal](https://make.powerapps.com/) for your organization. Also, verify that you have necessary permissions to view the in-app notifications. More information: [Enable the in-app notification feature](/power-apps/developer/model-driven-apps/clientapi/send-in-app-notifications?tabs=clientapi#enable-the-in-app-notification-feature)      

- You must have the **Salesperson** privileges to receive incoming messages. If you have insufficient privileges, you're notified about the same through the in-app notification center. Contact your administrator to get sufficient privileges to use the text message feature. More information: [Salesperson permissions for the SMS feature](sms-intro.md#salesperson-roles-sms-feature) 

## How incoming text messages are routed?

The incoming messages (replies) are attached to a record with the phone number from which the outbound message was sent. If same phone number is associated with multiple records, then the incoming messages are routed to the record in the following priority order: 

-	Contains most recent conversation between the seller and the customer.
-	Owned by a seller to whom the incoming message is addressed.
-	Owned by a seller who belongs to the team owning the phone number.
-	Record entity type in following order: 
    -	Contact
    -	Account
    -	Opportunity
    -	Lead
-	Active record receives the message over the inactive record.
-	Updated most recently.

When you receive a message from a number that isn't associated with a record, a new lead is created with the number and the incoming message is linked to that lead.

## Open text message conversations

You can only view conversations if the outbound phone number or record is assigned to you or your team. To view the conversations, use one of the following ways:

- **Activities grid**: 
    
    1. Go to the **Activities** grid and select **Conversation** > **My text messages** from the view selector.       
        A list of conversation that is related you is displayed.        
    1. Double-click a conversation.   
        The conversation pane opens on the right-side of the page.  
        
- **Record**: 
    
    1. Open a record (account, contact, lead, or opportunity).        
    1.  Select the message icon corresponding to a phone number (Business Phone or Mobile Phone),          
        >[!NOTE]
        >For opportunity records, open the **Activity** tab and then double-click a conversation that you want to view.           
        The conversation pane opens on the right-side of the page.
        
- **Notification center**: 

    1. Open your sales app and on the navigation bar, select the bell icon.           
        The in-app notifications are displayed.                
    1. Select the notification.            
        The **Activities** grid opens with the list of conversations related to you.       
    1. Double-click a conversation.    
        The conversation pane opens on the right-side of the page.

- **Sales accelerator workspace**:

    Open the text message step from the **Up next** widget or the work list item. More information: [Send a text message to customers](connect-with-customers.md#send-a-text-message-to-customers)  
    
## Understand the conversation pane

The conversation pane is where you, as a seller, interact with your customer. You can do the following tasks through the conversation pane:

- Send and receive text messages.   
- Choose templates to send personalized messages.    
- Choose a phone number to send a message.   
- View the history of the conversation related to the record.   
The following image is an example of the conversation pane.

:::image type="content" source="media/sms-inbound-communication-pane.png" alt-text="Screenshot of the text message communication page." lightbox="media/sms-inbound-communication-pane.png":::

1. **Related conversation to the selected phone number**: This option is available only for contact and opportunity records. When you open a contact, the drop-down displays a list of opportunities that are related to this contact. You can choose an option from the list to view the history and manage conversations related to that record.   

2. **Manage templates**: Choose templates to send personalized messages to customers. Also, you can choose to create templates if any of the existing templates doesn't meet your requirements. More information: [Personalize text messages through templates](create-text-message-templates.md)  

3. **Choose phone number**: If multiple phone numbers are assigned to you or your team, you can choose a number from which you want to send and receive the message. More information: [Set up the SMS provider in Dynamics 365 Sales](configure-sms-provider.md#set-up-the-sms-provider-in-dynamics-365-sales) 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Engage with customers through text messages](sms-intro.md)   
[Send a text message to customers](connect-with-customers.md#send-a-text-message-to-customers)    

