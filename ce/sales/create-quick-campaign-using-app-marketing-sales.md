---
title: "Create a quick campaign using in-app marketing | MicrosoftDocs"
description: "A quick campaign is a single campaign activity meant for a specific audience. For example, sending an e-mail blast to customers in a specific region."
ms.date: 10/03/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-Entity-bulkoperation
  - D365-UI-Form
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Create a quick campaign using in-app marketing

Send an e-mail blast to customers who fit a specific demographic, a mail campaign to clients in a specific region, or perhaps a phone call campaign to previous buyers of a particular product by using a quick campaign in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. 

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|
  

## When to use quick campaign

A quick campaign is a single campaign activity geared towards a targeted audience. Track the success of your quick campaign through campaign responses, and convert the positive responses into new leads, quotes, orders, or opportunities.
  
If you need to perform more than one activity for your campaign, such as an email blast and a phone call, create a standard campaign instead. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)


## Create a quick campaign and activity

When you create a quick campaign activity, an activity is created for each member in the marketing list that's part of the quick campaign.
 
> [!NOTE]
> The average time for distributing a quick campaign activity to 100,000 members is 24 hours. For larger campaigns and faster activity distribution, use Dynamics 365 Marketing. For more information, go to [Dynamics 365 Marketing documentation](../marketing/overview.md).

1. In the site map, select **Marketing Lists**.
  
2. Open a record, and then in the **Quick Campaigns** area, select **New Quick Campaign**.  
   > [!NOTE]
   >  You can't add members to a quick campaign after you create it.  
  
3. In the **Create a Quick Campaign** wizard, read the instructions on the welcome page, and then select **Next**.
  
4. On the **Specify the Campaign Name** step, enter a name for the quick campaign, and then select **Next**.
  
5. On the **Select the Activity Type and Owners** step, from the **Activity Type** list, select the type of activity you want to create.  
    > [!NOTE]
    > Supported activity types are email, appointment, phone call, fax, and letter. Custom activities or other out-of-the-box activities are not supported.  

   ![Quick campaign wizard.](media/quick-campaign-wizard.png "Quick campaign wizard") 

      You can also select who you want [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] to assign the activity to and whether [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] should perform the activity automatically for appropriate activities, such as sending email messages. For example, if you are creating a phone call activity for all the sales representatives, you can select the **Activity Type** as **Phone Call**, and then select **The owners of the records in the target marketing lists**. Each sales representative can then see the activity and take action on it. However, if you are creating a large number of email activities that [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] will perform automatically, you can assign the email activity to yourself instead of the record owners.


  5. When you select the **Activity Type** as *Email*, you'll see an additional checkbox **Mark email messages to be sent and close corresponding email activities**. Perform one of the following actions: 
      - Select the checkbox if you want the system to create an email activity for each member in the marketing list, send the email, and close the activity. In this case, an activity is considered successful when the email is marked to be sent.
    
      - Clear the checkbox if you want the system to just create an email activity for each member in the marketing list, and you want to manually send the email and close the activity. In this case, an activity is considered successful when the activity is created.
      
      You'll see the number of successes and failures after your create the campaign. 

6. Select **Next**.

6. On the **Specify the Content of the Activity** step, specify the details of the activity to be created, and then select **Next**.  

7. On the **Completing the Create Quick Campaign Wizard** step, select **Create**.  
    The campaign activity is added to the **Quick Campaigns** section. 
8. After the **Status Reason** field is marked as Completed, verify the **No. of Successes** and **No. of Failures** fields to know the number of activities that have succeeded or failed. In the case of email activities, successes and failures don't indicate email delivery status, instead they indicate the status of email activity creation in Dynamics 365.
1.  To view more details about the activities, open the quick campaign:
    -  To view more information about the type, owner, and status of the activities created for the campaign, view the **Timeline** section.
        > [!NOTE]
        > If your campaign has letter or fax activities, they'll not be listed in the timeline by default. To view them, select **Related** > **Activities**.  
    - To view the reasons for failures, select **Related** > **Members** and select the corresponding failure view. For example, if your campaign was targeted to accounts, select **Account Bulk Operations Failures** view.

 

 
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Get started with in-app marketing](get-started-app-marketing-sales.md)   
[Create a marketing list using in-app marketing](create-marketing-list-using-app-marketing-sales.md)   
[Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   
[Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)   
[Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
[Track a marketing campaign response using in-app marketing](track-marketing-campaign-response-using-app-marketing-sales.md)   
[Customize quick campaign and campaign activity distribution forms](developer/marketingformdisplayattributessetApi.md)
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
