---
title: "Review settings and import data (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: mkaur
ms.assetid: 69ee9e50-13cc-428a-9b7c-e0f1c9dae159
caps.latest.revision: 25
ms.author: mduelae
manager: kvivek
search.audienceType: 
  - enduser

---
# Review settings and import data

Set whether the Import Data wizard checks for and handles duplicate data on import, decide who can edit or share the imported data, and save the settings you used for this import so you can use them again later.  
  
### Check for duplicate data  
  
1.  Make sure there is a duplicate detection rule for the type of information you're importing. By default, the system includes rules for contacts, accounts, and leads. If you're importing a different type of data and need to set up duplicate detection rules, follow the steps in [Enable and Disable duplicate detection](/powerapps/developer/common-data-service/enable-disable-duplicate-detection).  
  
2.  If it's okay for the Import Data wizard to import duplicate records, in the **Allow Duplicates** section, select **Yes**.  
  
    > [!CAUTION]
    >  In most cases, to avoid importing duplicate information, you should keep this option set to **No**.  
  
### Set who owns the imported data  
  
1.  To set who owns the imported records, in the **Select Owner for the Imported Records** section, click or tap the **Lookup** button ![Lookup button](../basics/media/lookup-button-4.gif "Lookup button").  
  
    > [!IMPORTANT]
    >  Who should "own" the imported data? Most security roles allow people to view the data. However, the owner is also allowed to edit and share it. Here's an example: If your import file contains contacts you collected at a trade show and you want to assign a user to follow up with these contacts, select that person for the owner.  
    >   
    >  To assign someone other than yourself as the owner of the imported records, your security role must include permissions to create records for the user. If you don't have sufficient permissions, the wizard assigns you as the owner of the imported records by default.  
    >   
    >  Also, if applicable, ownership is assigned to the person defined in the data map metadata and users.csv file.  
  
2.  In the search box, type the person's name, then click or tap the **Lookup** button ![Lookup button](../basics/media/lookup-button-4.gif "Lookup button").  
  
3.  Select the name, then click or tap **Add**.  
  
### Save these import settings to use again  
  
1.  To save these import settings so you can use them again, enter a name for the settings (called a "data map").  
  
     The next time you run the Import Data wizard, you'll see the new data map listed under **Custom Maps**.  
  
2.  To import the data, click or tap **Submit**.  
  
### See also  
 [Import contacts](../basics/import-contacts.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]