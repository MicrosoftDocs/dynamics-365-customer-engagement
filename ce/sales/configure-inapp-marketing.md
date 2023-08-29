---
title: Configure in-app marketing settings
description: Configure in-app marketing settings to define various aspects of campaigning.
ms.date: 01/25/2023
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.custom: bap-template
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

  
## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## To configure in-app marketing settings

Depending on the Dynamics 365 Sales license you have, select one of the following tabs for specific information: 

# [Sales Premium and Sales Enterprise](#tab/SE)

1. In the Sales Hub app, go to the **Change Area** and select **App Settings**.

2. Under **Sales Administration**, select **Marketing settings**.

3. Configure the following settings in accordance with your requirements.
    
    |Setting  |Description  |
    |---------|---------|
    |Create campaign responses for incoming email     |If this option is set to **Yes**, the app automatically creates a campaign response  when an email is received in response to a specific marketing campaign. <br> **Note:** If a customer sends multiple replies to campaign email, only the first reply is tracked as a campaign response. <br>**Default:** Yes        |
    |Set "Do Not Send Marketing Material" option when an unsubscribe email is received     |If this option is set to **Yes**, when an unsubscribe email is received, the preference setting for the account, contact, or lead gets updated automatically to not send marketing materials. If this option is set to **No**, the unsubscribe email will be ignored and the user will continue to get marketing email communications. If you're providing an option to unsubscribe in the campaign emails, we recommend that you set this option to **Yes**.<br> More information: [Let your customers unsubscribe from marketing communications](get-started-app-marketing-sales.md#let-your-customers-unsubscribe-from-marketing-communications)<br> **Default:** No        |
    |Send acknowledgement to customers when they unsubscribe     | If **Set "Do Not Send Marketing Material" option when an unsubscribe email is received** is set to **Yes**, you can use this setting to send a response to customers when they unsubscribe.        |
    |Template for Acknowledgement Email     | If the previous two options are set to **Yes**, select an email template to use for responding to customers when they unsubscribe.        |

4. Save the changes.

# [Sales Professional](#tab/SP)

1. From the Sales Professional app, go to **Settings** > **Advanced Settings**.
1. Follow the instructions in the [System Settings Marketing tab](/power-platform/admin/system-settings-dialog-box-marketing-tab) article to open the marketing settings and configure them.  

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 
  
### See also  

[Create a marketing list using in-app marketing](create-marketing-list-using-app-marketing-sales.md)   
[Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   
[Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md)   
[Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)   
[Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
[Track a marketing campaign response using in-app marketing](track-marketing-campaign-response-using-app-marketing-sales.md)  
    

