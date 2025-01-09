---
title: "Merge duplicate records in Dynamics 365 Customer Engagement (on-premises)"
description: "Duplicate records can creep in when data is entered manually or imported in bulk. Use these steps to merge duplicate records for accounts, contacts, or leads."
ms.custom:
ms.reviewer:

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: shwetamurkute
ms.assetid: 3e3aba01-d5d0-469b-8b21-e857ad9e64dd
caps.latest.revision: 50
ms.author: smurkute
search.audienceType: 
  - enduser

---
# Merge duplicate records for accounts, contacts, or leads

::: moniker range=">= op-9-1"

[!INCLUDE [applies-to-unified-interface](../includes/applies-to-unified-interface.md)] [Merge duplicate records](/powerapps/user/merge-duplicate-records)

Duplicate records can creep into your data when you or others enter data manually or import data in bulk. Dynamics 365 Customer Engagement (on-premises) helps you address potential duplicates by providing duplicate detection for active records such as, accounts, contacts, and leads. When you merge a record any related or child records will also be merged.  Your administrator may also set up duplicate detection rules for other situations.  


  
 For example, let's say you enter a contact record, Jim Glynn,  along with a mobile phone number.  The duplicate detection rule discovers that you already have a similar record, and displays this dialog box.  
  
 ![Duplicate contact record detectied in Dynamics 365 Customer Engagement (on-premises).](../basics/media/duplicates-detected.png "Duplicate contact record detectied in Dynamics 365 Customer Engagement (on-premises)")  
  
 You're not sure if this is a new record (one that happens to have the  same name as an existing contact) or a duplicate, so you click **Save**.  
  
 Next, you go to the **My Active Contacts** list and see that now you have two records with the same name. After reviewing the records,  you  determine that they're duplicates that need to be merged.  
  
   > [!div class="mx-imgBorder"] 
   > ![Duplicate contacts listed in the My Active Contacts list in Dynamics 365 Customer Engagement (on-premises).](../basics/media/duplicates-list.png "Duplicate contacts listed in the My Active Contacts list in Dynamics 365 Customer Engagement (on-premises)")  
 
Dynamics 365 Customer Engagement (on-premises) includes duplicate detection rules for accounts, contacts, and leads. These rules are automatically turned on, so you don't have to do anything to set up duplicate detection for these record types.  
  
> [!NOTE]
>  If available on your system, you may also be able to check for duplicates of other record types, in addition to contacts, accounts, and leads. Check with your system administrator. [Find your Dynamics 365 Customer Engagement (on-premises) administrator or support person](../basics/find-administrator-support.md)  
  
## Merge duplicate records  
  
1. Select the duplicate records, and then click **Merge**.  
  
   > [!div class="mx-imgBorder"] 
   > ![Merge records button in Dynamics 365 Customer Engagement (on-premises).](../basics/media/merge-contact-sbutton.png "Merge records button in Dynamics 365 Customer Engagement (on-premises)")  
  
2. In the **Merge Records** dialog box, select the master record (the one you want to keep), and then select any fields in the new record that you want to merge into the master record. Data in these fields may override the existing data in the master record. Click **OK**.  
  
   ![Dialog box for merging records in Dynamics 365 Customer Engagement (on-premises).](../basics/media/merge-records-dialog.png "Dialog box for merging records in Dynamics 365 Customer Engagement (on-premises)")  
  
> [!NOTE]
>  There are three situations when duplicates may be found:  
> 
> - When a record is created or updated.  
>   - When  you're using [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and you go from offline to online.  
>   - When you import data using the Import Data wizard.  
> 
>   Duplicates aren't detected when you merge records, convert a lead, save an activity as completed, or change the status of a record, such as activating or reactivating a record.  
  
  
### See also  
 [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]



::: moniker-end

::: moniker range="< op-9-1"


[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Merge duplicate records](/powerapps/user/merge-duplicate-records)

Duplicate records can creep into your data when you or others enter data manually or import data in bulk. Dynamics 365 Customer Engagement (on-premises) helps you address potential duplicates by providing duplicate detection for active records such as, accounts, contacts, and leads. When you merge a record any related or child records will also be merged.  Your administrator may also set up duplicate detection rules for other situations.  


  
 For example, let's say you enter a contact record, Jim Glynn,  along with a mobile phone number.  The duplicate detection rule discovers that you already have a similar record, and displays this dialog box.  
  
 ![Duplicate contact record detectied in Dynamics 365 Customer Engagement (on-premises).](../basics/media/duplicates-detected.png "Duplicate contact record detectied in Dynamics 365 Customer Engagement (on-premises)")  
  
 You're not sure if this is a new record (one that happens to have the  same name as an existing contact) or a duplicate, so you click **Save**.  
 
> [!NOTE]
>  There are three situations when duplicates may be found:  
> 
> - When a record is created or updated.  
> - When you're using [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and you go from offline to online.  
> - When you import data using the Import Data wizard.  
> 
>   Duplicates aren't detected when you merge records, convert a lead, save an activity as completed, or change the status of a record, such as activating or reactivating a record.  

 Next, you go to the **My Active Contacts** list and see that now you have two records with the same name. After reviewing the records,  you  determine that they're duplicates that need to be merged.  
  
   > [!div class="mx-imgBorder"] 
   > ![Duplicate contacts listed in the My Active Contacts list in Dynamics 365 Customer Engagement (on-premises).](../basics/media/duplicates-list.png "Duplicate contacts listed in the My Active Contacts list in Dynamics 365 Customer Engagement (on-premises)")  
 
Dynamics 365 Customer Engagement (on-premises) includes duplicate detection rules for accounts, contacts, and leads. These rules are automatically turned on, so you don't have to do anything to set up duplicate detection for these record types.  
  
> [!NOTE]
>  If available on your system, you may also be able to check for duplicates of other record types, in addition to contacts, accounts, and leads. Check with your system administrator. [Find your Dynamics 365 Customer Engagement (on-premises) administrator or support person](../basics/find-administrator-support.md)  
  
## Merge duplicate records  
  
1. Select the duplicate records, and then click **Merge**.  
  
   > [!div class="mx-imgBorder"] 
   > ![Merge records button in Dynamics 365 Customer Engagement (on-premises).](../basics/media/merge-contact-sbutton.png "Merge records button in Dynamics 365 Customer Engagement (on-premises)")  
  
2. In the **Merge Records** dialog box, select the master record (the one you want to keep), and then select any fields in the new record that you want to merge into the master record. Data in these fields may override the existing data in the master record. Click **OK**.  
  
   ![Dialog box for merging records in Dynamics 365 Customer Engagement (on-premises).](../basics/media/merge-records-dialog.png "Dialog box for merging records in Dynamics 365 Customer Engagement (on-premises)")  
  
> [!NOTE]
>  The fields that show in the merge dialog come from the default form for the entity. There are three situations where fields from that form will still not show:  
> 
> - When a neither records being merged have data for the field.
> - When a user does not have access to the field due to Field Level Security.
> - When a field is not visible (this can be due to either the cell or the section not being visible by default).
>   
  
  
### See also  
 [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]


::: moniker-end

