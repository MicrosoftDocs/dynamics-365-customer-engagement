---
title: "Configure in-app marketing settings"
description: "Configure in-app marketing settings ."
ms.date: 02/22/2022
ms.custom: intro-internal
ms.topic: get-started-article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
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

1. In the Sales Hub app, go to the Change Area and select **App Settings**.

3. Under **General Settings**, select **Marketing settings**.

4. Configure the following settings as per your requirement:
    
    |Setting  |Description  |
    |---------|---------|
    |Enable Direct Email via Mail Merge     | If set to **Yes**, users can send email as a campaign activity using the mail merge feature. <br> **Note:** To use the mail merge feature, the users must be part of a security role that has the Mail Merge privilege.  <br>**Default:** Yes.        |
    |Create campaign responses for incoming email     |If set to **Yes**, the app creates campaign response records automatically when email messages are received in response to a specific marketing campaign. <br> **Note:** If there are multiple email replies from a customer to an email sent out from a campaign activity, only the first reply is tracked as a campaign response in the campaign. <br>**Default:** Yes        |
    |Set "Do Not Send Marketing Material" option when unsubscribe email is received     |If set to **Yes**, when an unsubscribe email is received, the preference setting for the account, contact, or lead from the marketing list gets updated automatically to not send marketing materials. <br> **Default:** No        |
    |Send acknowledgement to customers when they unsubscribe     | If the **Set "Do Not Send Marketing Material"** option is set to **Yes**, you can use this setting to send a response to customers when they unsubscribe.        |
    |Template for Acknowledgement Email     | If the previous two options are set to **Yes**, select an email template to use for responding to customers when they unsubscribe.        |

5. Save the changes.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 
  
### See also  
 [Create a marketing list using in-app marketing](create-marketing-list-using-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md)   
 [Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](track-marketing-campaign-response-using-app-marketing-sales.md)  
    

