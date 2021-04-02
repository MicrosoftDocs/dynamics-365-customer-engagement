---
title: "Create a marketing list using in-app marketing (Dynamics 365 Sales Professional) | MicrosoftDocs"
description: "Create marketing list in Dynamics 365 Sales Professional group your accounts, contacts or leads so you can send your marketing campaigns to these groups."
ms.date: 12/06/2019
ms.service: dynamics-365-sales
ms.topic: get-started-article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdyn_salespro
  - D365-Entity-list
  - D365-Entity-campaign
  - D365-Entity-bulkoperation
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create a marketing list using in-app marketing (Sales Professional)

Your marketing list is the core of running a successful marketing campaign. It can include any one type of customer record, such as leads, accounts, or contacts.  
  
 You can create two types of marketing lists:  
  
- **Static** Use a static list if you prefer to add and update members manually.  
  
- **Dynamic** Use a dynamic marketing list if you want the list to return a list of members dynamically when needed, based on search criteria you set. For example, if you want to run a campaign to members of a specific city, use a dynamic list. A dynamic marketing list retrieves the updated list of members each time you open the list, create a quick campaign from the list, or distribute a campaign activity for a campaign associated with the list.  
  
## Create a marketing list  
  
1. In the site map, select **Marketing Lists**.
  
2. Select **New**.  
  
3. Add or change the information in the **Summary** area.
  
   > [!NOTE]
   >  To look up records in the **Owner** field, first select **Save**, or you'll lose your changes.  
  
4. Select **Save** so you can enter information in other areas of the form.  
  
5. Select the **Notes** tab to add any other information that applies to your marketing list.  
  
6. Select **Save**.  
  
## Add members to a static marketing list  
  
In any marketing list record, select the **Members** tab, and on the command bar, select Manage Members and then select one of the following options.  
  
  #### Add using Lookup  
  
  1.  In the **Look Up Records** dialog box, select your search criteria.  
  
  2.  Select the records that you want to add, select **Select**, and then select **Add**.  
  
  #### Add using Advanced Find  
  
  1.  In the **Add Members** dialog box, select **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types. When you select a related record type, a new line appears with another Select list for the related record type.  
  
  2.  Select **Equals**, and then select a query relational operator (for example **Contains** or **Begins With**).  
  
  3.  Select **Enter Text**, and then type the value that you want to locate.  
  
  4.  To specify the columns to include in the search results, select **Edit Columns**, and then **Add Columns**. Then select the columns that you want to add, and select **OK**.  
  
  5.  Select **Find**.  
  
  6.  Select the members that you want to add, select one of the following, and then select **Add to Marketing List**.  
  
      -   Add only the selected members to the marketing list  
  
      -   Add all the members returned by the search to the marketing list  
  
  #### Remove using Advanced Find  
  
  1.  In the **Add Members** dialog box, select **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types. When you select a related record type, a new line appears with another Select list for the related record type.  
  
  2.  Select **Equals**, and then select a query relational operator (for example **Contains** or **Begins With**).  
  
  3.  Select **Enter Text**, and then type the value you want to locate.  
 
  4.  To specify the columns to include in the search results, select **Edit Columns**, and then select **Add Columns**. Then select the columns that you want to add, and select **OK**.  
  
  5.  Select **Find**.  
  
  6.  Select the members that you want to remove, select one of the following, and then select **Remove from Marketing List**.  
  
      -   Remove only the selected members from the marketing list  
 
      -   Remove all the members returned by the search from the marketing list  
  
  #### Evaluate using Advanced Find  
  
  1.  In the **Add Members** dialog box, select **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types. When you select a related record type, a new line appears with another Select list for the related record type.  
  
  2.  Select **Equals**, and then select a query relational operator (for example **Contains** or **Begins With**).  
  
  3.  Select **Enter Text**, and then type the value you want to locate.  
 
  4.  To specify the columns to include in the search results, select **Edit Columns**, and then select **Add Columns**. Then select the columns that you want to add, and select **OK**.  
  
  5.  Select **Find**.  
  
  6.  Select the members that you want to keep, select one of the following, and then select **Update Marketing List**.  
  
      -   Keep only the selected members in the marketing list  
  
      -   Keep all the members returned by the search in the marketing list  

> [!NOTE]
  > You can add up to 120,000 members to a static marketing list in one Add operation. If you need to add more than 120,000 members to a static marketing list, split those members into multiple add operations. One way to do this is by using the [Advanced Find](#add-using-advanced-find) dialog to create queries that return less than 120,000 members. Alternatively, depending on your scenario, you can also consider using a dynamic marketing list instead of static list. More information: [Create a dynamic marketing list](#define-the-member-selection-criteria-for-a-dynamic-marketing-list)

## Define the member selection criteria for a dynamic marketing list  
  
<a name="Collapsed3"></a>   
1.  In any marketing list, on the command bar, select **Manage Members**.  
  
2.  In the **Manage Members** dialog box, select **Select**, and then select the field on which you want to search, such as **Account Name** or **City**. You can select fields from the current record type, or from related record types.  
  
     When you select a related record type, a new line appears with another **Select** list for the related record type.  
  
3.  Select **Equals**, and then select a query relational operator.  
  
4.  Select **Enter Value**, and then type the value that you want to locate (for example, "Seattle" or "Email").  
  
     For some values, you can select the **Lookup** icon to open the **Select Values** dialog box and select the value you want.  
  
5.  To specify the columns to include in the search results, select **Edit Columns**, and then **Add Columns**. Select the columns that you want to add, and select **OK**.  
  
6.  Select **Use Query** to add the matching records to your dynamic marketing list.  
  
## Associate campaigns or quick campaigns to a marketing list  
 After you have created a campaign or quick campaign, you can associate it to your marketing list. You can also create a new campaign or quick campaign from your marketing list.  
  
1.  In the **Campaigns** or **Quick Campaigns** area, select the **Add**![Add button](../sales-enterprise/media/add-button.PNG "Add button") button.  
  
2.  Search for the campaign or quick campaign you want to associate to this marketing list.  
  
    > [!NOTE]
    >  If you don't have any campaigns, or if you want to create a new one, you can select **+ New**.  
    >   
    >  If you don't have any quick campaigns, the Quick Campaign Wizard will start.  
  
  
### See also  
 [Get started with in-app marketing](get-started-app-marketing-sp.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
