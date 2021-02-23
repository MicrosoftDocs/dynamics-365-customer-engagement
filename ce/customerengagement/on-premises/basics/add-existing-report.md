---
title: "Add a report from outside Dynamics 365 Customer Engagement (on-premises)| MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 9cfad031-e7a8-4c00-b59f-1ff359717c6e
caps.latest.revision: 25
author: Mattp123
ms.author: mduelae
manager: kvivek
search.audienceType: 
  - enduser

---
# Add a report from outside Dynamics 365 Customer Engagement (on-premises)


[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Add a report from outside Power Apps](/powerapps/user/add-existing-report)

If you've created a custom report outside of Dynamics 365 Customer Engagement (on-premises), you can easily add it to Customer Engagement (on-premises).  
  
1. [!INCLUDE[proc_reports](../includes/proc-reports.md)]  
  
2. Choose **New**.  
  
   **Add a file created in another application**  
  
   1. In the **Report Type** box, select **Existing File**.  
  
   2. Select **Choose File** and the browse to locate the file.  
  
      -OR  
  
   **Add a link to a webpage**  
  
   1.  In the **Report Type** box, select **Link to Webpage**.  
  
   2.  In the **Webpage URL** box, enter the URL of the webpage.  
  
3. Specify the properties for the report on the **General** tab.  
  
   1.  In the **Details** section, specify a meaningful name and description for the report.  
  
   2.  The **Parent Report** text box displays the parent report of the current report, if one exists.  
  
   3. **Categories**. Choose the **Select or change the values for this field**![Ellipsis button](../basics/media/ellipsis-button.gif "Ellipsis button") button, and then specify the categories to include in this report.  
  
   4. **Related Record Types**. To have the report appear in the Reports list on a page for specific record types, choose the **Select or change the values for this field**![Ellipsis button](../basics/media/ellipsis-button.gif "Ellipsis button") button, and then select record types.  
  
   5. **Display In**. To specify where reports should be visible, choose the **Select or change the values for this field**![Ellipsis button](../basics/media/ellipsis-button.gif "Ellipsis button") button, and then select one or more of the options.  
  
        If no values are selected, the report won't be visible to end users.  
  
4. Edit the report ownership information on the Administration tab:  
  
   - **Owner**  
  
        This option is only available if you have Assign permission for the report.  
  
   - **Viewable By**  
  
        Select **Organization** to make the report organization-owned, and to make it viewable by anyone in the organization. Select **Individual** to make the report viewable only by the owner and anyone the owner shares the report with.  
  
5. Choose **Save** or **Save and Close**.  
  
   To share the new report, see the instructions in [Share a report with other users or teams](../basics/share-report-users-teams.md).  
  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]