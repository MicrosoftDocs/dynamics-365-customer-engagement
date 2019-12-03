---
title: "Create a marketing list using in-app marketing (Dynamics 365 Sales) | MicrosoftDocs"
description: 
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: get-started-article
author: shubhadaj
ms.author: shujoshi
manager: sakudes
---

# Create a marketing list using in-app marketing (Sales)

Your marketing list is the core of running a successful marketing campaign. It can include any one type of customer record, such as leads, accounts, or contacts.  
  
 You can create two types of marketing lists:  
  
- **Static** Use a static list if you prefer to add and update members manually.  
  
- **Dynamic** Use a dynamic marketing list if you want the list to return a list of members dynamically when needed, based on search criteria you set. For example, if you want to run a campaign to members of a specific city, use a dynamic list. A dynamic marketing list retrieves the updated list of members each time you open the list, create a quick campaign from the list, or distribute a campaign activity for a campaign associated with the list.  
  
## Create a marketing list  
  
1. [!INCLUDE[proc_marketing_marketing_lists](../includes/proc-marketing-marketing-lists.md)]  
  
2. Click **New**.  
  
3. Add or change the information in the **Summary** area. This screenshot provides an example.  
  
   ![Example of marketing list summary area](../sales-enterprise/media/marketing-list-summary-example.png "Example of marketing list summary area")  
  
   > [!NOTE]
   >  To look up records in the **Owner** field, first click **Save**, or you'll lose your changes.  
  
4. Click **Save** so you can enter information in other areas of the form.  
  
5. Add any other information that applies to your marketing list in the **Notes** area.  
  
6. Click **Save**.  
  
## Add members to a static marketing list  
  
<a name="Collapsed2"></a>   
1.  In any marketing list record, in the **Members** area, click the **Add**![Add button](../sales-enterprise/media/add-button.PNG "Add button") button.  
  
2.  In the **Manage Members** dialog box, select one of the following options, and then click **Continue**.  
  
    #### Add using Lookup  
  
    1.  In the **Look Up Records** dialog box, select your search criteria.  
  
    2.  Select the records that you want to add, click **Select**, and then click **Add**.  
  
    #### Add using Advanced Find  
  
    1.  In the **Add Members** dialog box, click **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types. When you select a related record type, a new line appears with another Select list for the related record type.  
  
    2.  Click **Equals**, and then select a query relational operator (for example **Contains** or **Begins With**).  
  
    3.  Click **Enter Text**, and then type the value that you want to locate.  
  
    4.  To specify the columns to include in the search results, click **Edit Columns**, and then **Add Columns**. Then select the columns that you want to add, and click **OK**.  
  
    5.  Click **Find**.  
  
    6.  Select the members that you want to add, select one of the following, and then click **Add to Marketing List**.  
  
        -   Add only the selected members to the marketing list  
  
        -   Add all the members returned by the search to the marketing list  
  
    #### Remove using Advanced Find  
  
    1.  In the **Add Members** dialog box, click **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types. When you select a related record type, a new line appears with another Select list for the related record type.  
  
    2.  Click **Equals**, and then select a query relational operator (for example **Contains** or **Begins With**).  
  
    3.  Click **Enter Text**, and then type the value you want to locate.  
  
    4.  To specify the columns to include in the search results, click **Edit Columns**, and then click **Add Columns**. Then select the columns that you want to add, and click **OK**.  
  
    5.  Click **Find**.  
  
    6.  Select the members that you want to remove, select one of the following, and then click **Remove from Marketing List**.  
  
        -   Remove only the selected members from the marketing list  
  
        -   Remove all the members returned by the search from the marketing list  
  
    #### Evaluate using Advanced Find  
  
    1.  In the **Add Members** dialog box, click **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types. When you select a related record type, a new line appears with another Select list for the related record type.  
  
    2.  Click **Equals**, and then select a query relational operator (for example **Contains** or **Begins With**).  
  
    3.  Click **Enter Text**, and then type the value you want to locate.  
  
    4.  To specify the columns to include in the search results, click **Edit Columns**, and then click **Add Columns**. Then select the columns that you want to add, and click **OK**.  
  
    5.  Click **Find**.  
  
    6.  Select the members that you want to keep, select one of the following, and then click **Update Marketing List**.  
  
        -   Keep only the selected members in the marketing list  
  
        -   Keep all the members returned by the search in the marketing list  

  > [!NOTE]
  > You can add up to 120,000 members to a static marketing list in one add operation. If you need to add more than 120,000 members to a static marketing list then you should split those members into multiple add operations. One way to do this is by using the [Advanced Find](#add-using-advanced-find) dialog to create queries that return less than 120,000 members. Alternatively, depending on your scenario you can also consider using a [dynamic marketing](#Define-the-member-selection-criteria-for-a-dynamic-marketing-list) list instead of static list.

## Define the member selection criteria for a dynamic marketing list  
  
<a name="Collapsed3"></a>   
1.  In any marketing list, on the command bar, select **Manage Members**.  
  
2.  In the **Manage Members** dialog box, click **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types.  
  
     When you select a related record type, a new line appears with another **Select** list for the related record type.  
  
3.  Click **Equals**, and then select a query relational operator.  
  
4.  Click **Enter Value**, and then type the value that you want to locate (for example, "Seattle" or "Email").  
  
     For some values, you can click the **Lookup** icon to open the **Select Values** dialog box and select the value you want.  
  
5.  To specify the columns to include in the search results, click **Edit Columns**, and then **Add Columns**. Select the columns that you want to add, and click **OK**.  
  
6.  Click **Use Query** to add the matching records to your dynamic marketing list.  
  
## Associate campaigns or quick campaigns to a marketing list  
 After you have created a campaign or quick campaign, you can associate it to your marketing list. You can also create a new campaign or quick campaign from your marketing list.  
  
1.  In the **Campaigns** or **Quick Campaigns** area, click the **Add**![Add button](../sales-enterprise/media/add-button.PNG "Add button") button.  
  
2.  Search for the campaign or quick campaign you want to associate to this marketing list.  
  
    > [!NOTE]
    >  If you don't have any campaigns, or if you want to create a new one, you can click **+ New**.  
    >   
    >  If you don't have any quick campaigns, the Quick Campaign Wizard will start.  
  
  
### See also  
 [Get started with in-app marketing](../sales-enterprise/get-started-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](../sales-enterprise/create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](../sales-enterprise/create-quick-campaign-using-app-marketing-sales.md)   
 [Add an activity to a campaign using in-app marketing](../sales-enterprise/add-activity-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](../sales-enterprise/add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](../sales-enterprise/track-marketing-campaign-response-using-app-marketing-sales.md)   
 
