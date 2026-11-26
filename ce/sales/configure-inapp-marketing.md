---
title: Configure in-app marketing settings
description: Learn how to configure in-app marketing settings to define various aspects of campaigning, including creating campaign responses automatically.
ms.date: 09/25/2026
ms.update-cycle: 1095-days
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - bap-template
  - evergreen
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-UI-Form
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Configure in-app marketing settings

Configure the in-app marketing settings to define various aspects of campaigning. For example, you can specify whether you want to create a campaign response automatically when a customer responds to a campaign email. 

  
## To configure in-app marketing settings

Select a tab based on the sales app that you use:

# [Sales Hub app](#tab/SE)

1. In the Sales Hub app, go to the **Change area** and select **App Settings**.

2. Under **Sales Administration**, select **Marketing Settings**.

3. Configure the following settings in accordance with your requirements.
    
    | Setting | Description |
    |---------|-------------|
    | Enable the new enhanced quick campaign experience (preview) | Set to **Yes** to use the enhanced experience to create and manage quick campaigns.<br>Enhanced experience includes improved user experience and streamlined campaign management. For more information, see [Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md).<br>**Default:** No |
    | Create campaign responses for incoming email | Set to **Yes** to automatically create a campaign response when an email is received in response to a specific marketing campaign. You must enable email tracking at the campaign level for automatic creation of campaign responses.<br>**Note:** If a customer replies to a campaign email multiple times, only the first reply is tracked as a campaign response.<br>**Default:** Yes |
    | Set "Do Not Send Marketing Material" option when an unsubscribe email is received | Set to **Yes** to automatically update the account, contact, or lead preference to prevent marketing materials from being sent. If set to **No**, unsubscribe emails are ignored and the customer continues to receive marketing emails. If campaign emails include an unsubscribe option, set this option to **Yes**.<br>For more information, see [Let your customers unsubscribe from marketing communications](get-started-app-marketing-sales.md#let-your-customers-unsubscribe-from-marketing-communications).<br>**Default:** No |
    | Send acknowledgement to customers when they unsubscribe | If **Set "Do Not Send Marketing Material" option when an unsubscribe email is received** is set to **Yes**, use this setting to send customers a response when they unsubscribe. |
    | Template for Acknowledgement Email | If the previous two options are set to **Yes**, select the email template to use when responding to customers who unsubscribe. |

4. Save the changes.

# [Sales Professional app](#tab/SP)

1. From the Sales Professional app, go to **Settings** > **Advanced Settings**.
1. Follow the instructions in the [System Settings Marketing tab](/power-platform/admin/system-settings-dialog-box-marketing-tab) article to open the marketing settings and configure them.  

---

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 
  
## Related information  

[Create a marketing list using in-app marketing](create-marketing-list-using-app-marketing-sales.md)   
[Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   
[Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md)   
[Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)   
[Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
[Track a marketing campaign response using in-app marketing](track-marketing-campaign-response-using-app-marketing-sales.md)  
    


