---
title: "Add activity to campaign in in-app marketing - Sales Enterprise | MicrosoftDocs"
description: "Create, distribute, and assign planning and campaign activities to a marketing campaign in Dynamics 365 Sales to make it successful."
ms.date: 10/01/2019
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-Entity-campaignactivity
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---

# Add activity to campaign using in-app marketing

Make your marketing campaigns successful by creating, distributing, and assigning planning and campaign activities in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. Planning activities are those you want to perform before you launch the campaign, and campaign activities are those you want to manage as part of the campaign. Examples of planning and campaign activities you can add include:  
  
- Identify advertising channels and supporting materials  
  
- Contact media channels to reserve time or space for advertising  
  
- Create or refine target marketing lists  
  
- Contact a design agency to request creation of collateral pieces and advertising materials  
  
  By default, a campaign targets an activity to the group of marketing lists that you select for the campaign. If you want to run a campaign activity on a subset of your marketing lists, you can distribute the activity to certain members instead.  
  
<a name="Collapsed1"></a>   
## Add a planning activity to a campaign  
  
1. In the site map, select **Marketing Lists**.

2. Open a marketing list record, and then in the **Campaigns** area, open the campaign to which you want to add a planning activity. 

3. To add a new activity, on the **Related** tab, select **Planning Activities**, then select **New Activity**, and then select the type of activity you want to create.  
  
    -OR-  
  
    To add an existing activity, select **Add Existing Activity**. In the inline lookup field, search for and select the activity.  
  
4. In the new activity form, add or change information in the text boxes.  
  
5. When you're ready to save your data, select **Save**.  
  
## Add a campaign activity to a campaign  
  
1. In the site map, select **Marketing Lists**, and from the **Campaigns** area, open the campaign to which you want to add a campaign activity.

2. On the **Related** tab, select **Campaign Activities**, and then select **New Campaign Activity**.
  
3. In the **Summary** section of the **Campaign Activity** form, enter the required information: 

    a.  **Subject**. Type the objective of the campaign activity.
    
    b.  **Used in Campaign.** When you create the campaign activity from a campaign, the campaign is automatically added here. 

    c.  **Channel.** Select the channel through which the communication for this activity must be sent. For example, phone, letter, or email. 
    
    d.  Scheduled start and end date. Enter the expected date and time the activity is scheduled to start and end.   

4. In the **Anti-Spam Settings** section, enter the frequency cap (in days) for marketing activities directed at any contact. Contacts that have been contacted more recently than this will be excluded from new campaign activity distributions. Enter "0" to disable the limit.

5. (Optional) Select the **Audiences** tab to view the information about the records (account, contact, and lead) for whom the activity has been created based on the channel type of the campaign activity. These records are the ones present in the marketing list(s) associated to the campaign activity. 

    >[!NOTE]
    >To view the **Audiences** tab, select the **Campaign Activity** form.
    
    | Option type | Description |
    |-------------|-------------|
    | Accepted *table type* | Activity is created for these records to be acted on based on the activity type mentioned in the channel for the campaign activity. |
    | Excluded *table type* | The users in this section have opted out of any **Marketing Materials** or opted out of certain type of marketing materials like email or phone call only. This information for the respective record can be seen in the **Details** tab of the record (account, contact, or lead). The other reason could be lack of information. For example, for **Channel Type as Email** of a campaign activity, the records with no email ID associated to them will be excluded. |  
    
5. On the Campaign Activity form, select **Save**.

6. The marketing list from which the campaign activity is created is automatically added in the Marketing list section. To add more marketing list, select the **More Commands** icon ![More Commands icon.](media/more-commands-button.png "More Commands icon"), and then select **Add Existing Marketing List**.  
  
7. To distribute the new campaign activity, on the command bar, select **Distribute Campaign Activity**.  
  
8. In the activity form, type or modify information in the text boxes, and select **Distribute**.  
  
9. Choose who will own the activities, and select **Distribute**.  
  
   > [!NOTE]
   > 1.  You can only distribute campaign activities of type "mail merge" to marketing lists that contain the same type of record. For example, if one marketing list contains accounts and a second marketing list contains leads, the mail merge campaign activity will fail. Create a separate mail merge campaign activity for each group of marketing lists with the same record type. 
   > 2.  When you distribute a campaign activity or run a quick campaign, and if a contact, account, or lead in the target audience (typically specified in a marketing list) doesn't have data in the Email, Fax, Address, or Primary Phone fields, respective activities like Email, Phone, Letter, and Fax won't be created for that contact, account or lead. 
  
10. After all the distributed activities are closed, you can close the campaign activity. To close the campaign activity, open the campaign activity record, and on the command bar, select **Close Campaign Activity**. Set an appropriate status for the activity, and select **OK**.  
  
11. When the activity is completed, update the campaign activity record with the actual costs. Open the campaign activity and update the **Actual Cost** field. This can help guide you in planning future campaign activities.  
  
  
### See Also  
 [Get started with in-app marketing](../sales-enterprise/get-started-app-marketing-sales.md)   
 [Create a marketing list using in-app marketing](../sales-enterprise/create-marketing-list-using-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](../sales-enterprise/create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](../sales-enterprise/create-quick-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](../sales-enterprise/add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](../sales-enterprise/track-marketing-campaign-response-using-app-marketing-sales.md)   
 [Customize quick campaign and campaign activity distribution forms](../sales-enterprise/developer/marketingformdisplayattributessetApi.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
