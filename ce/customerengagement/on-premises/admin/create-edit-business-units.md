---
title: "Create or edit business units  | MicrosoftDocs"
ms.custom: 
ms.date: 10/02/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: 0a7ad0db-887f-4139-b3d1-8f18a84b10d2
caps.latest.revision: 14
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin

---
# Create or edit business units to improve security and control

In Dynamics 365 Customer Engagement (on-premises), a business unit is a logical grouping of related business activities.  
  
 If your Customer Engagement (on-premises) organization is structured around departments or divisions that have separate products, customers, and marketing lists, you might want to create business units. Business units are mapped to an organization’s departments or divisions. Users can securely access data in their own business unit, but they can’t access data in other business units.  
  
 Business units, security roles, and users are linked together in a way that conforms to the Customer Engagement (on-premises) role-based security model. Use business units together with security roles to control data access so people see just the information they need to do their jobs. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security concepts](../admin/security-concepts.md)  
  
 Keep the following in mind when creating business units:  
  
- The organization (also known as the root business unit) is the top level of a Customer Engagement (on-premises) business unit hierarchy. Customer Engagement (on-premises) automatically creates the organization when you install or provision Customer Engagement (on-premises). You can’t change or delete the organization name.  
  
- Each business unit can have just one parent business unit.  
  
- Each business unit can have multiple child business units.  
  
- Customer Engagement (on-premises) security roles and users are associated with a business unit. You must assign every user to one (and only one) business unit.  
  
- You can assign a team to just one business unit, but a team can consist of users from one or many business units. Consider using a team if you have a situation where users from different business units need to work together on a shared set of records.  
  
<a name="BKMK_createnew"></a>   

## Create a new business unit  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Business Units**.  
  
3. On the Actions bar, select **New**.  
  
4. In the **Business Unit** dialog box, type a name for the new business unit. Customer Engagement (on-premises) automatically fills in the **Parent Business** field with the name of the root business unit.  
  
   ![Business Unit dialog box in Dynamics 365 for Customer Engagement](../admin/media/business-unit-dialog-box.png "Business Unit dialog box in Dynamics 365 for Customer Engagement")  
  
5. If you want to change the parent business unit, select the **Lookup** button ![Lookup button](../admin/media/lookup-4.gif "Lookup button"), **Look Up More Records**, and then do one of the following:  
  
   -   Select an existing business unit from the list.  
  
   -   Create a new parent business unit:  
  
       1.  Choose **New**, and then add the information for the new parent business unit in the **Business Unit** dialog box.  
  
       2.  When you’re done adding information, select **Save and Close**.  
  
       3.  In the **Look Up Record** dialog box, select **Add**.  
  
6. In the **Business Unit** dialog box, fill in any of the other optional fields, such as the Division, Website, contact information, or addresses.  
  
7. When you’re done making entries, select **Save and Close**.  
  
<a name="BKMK_changesettings"></a>   

## Change the settings for a business unit  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Business Units** and then select a business unit name.  
  
3. In the **Business Unit** dialog box, do one or more of the following:  
  
   -   Modify the data in one or more fields.  
    
   -   Select a record type under **Organization** to see a list of related records. For example, select **Users** to view a list of users in the selected business unit.  
  
4. When you’re done making changes select **Save and Close**.  

<a name="BKMK_changebusinessunit"></a>   

## Change the business unit for a record  
 You can change the business unit for an individual facility, equipment, or user.   
  
### Change the business unit for facilities or equipment  
  
1. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
2. Choose **Facilities/Equipment**.  
  
3. Select the **Name** of a piece of equipment or a facility.  
  
4. In the **Facility/Equipment** dialog box, on the **Actions** menu, choose **Change Business Unit**.  
  
5. In the **Change Business Unit** dialog box, use the **Lookup** button ![Lookup button](../admin/media/lookup-4.gif "Lookup button") to select a new business unit, and then select **OK**.  
  
6. Select **Save and Close**.  

### Change the business unit for a user  

> [!IMPORTANT]
> By changing the business unit for a user, you remove all security role assignments for the user. At least one security role must be assigned to the user in the new business unit.  More information: [Security roles](../admin/security-roles-privileges.md).
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Users**.  
  
3. Select a user name.  
  
4. On the **More Commands** (**…**) menu, select **Change Business Unit**.  
  
5. In the **Change Business Unit** dialog box, use the **Lookup** button ![Lookup button](../admin/media/lookup-4.gif "Lookup button") to select a new business unit, and then select **OK**.  
  
### See also  
 [Set up an organization](../admin/set-up-a-dynamics-365-organization.md)   
 [Delete a business unit](../admin/delete-business-unit.md)   
 [Assign a business unit a different parent business](../admin/assign-business-unit-different-parent.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]