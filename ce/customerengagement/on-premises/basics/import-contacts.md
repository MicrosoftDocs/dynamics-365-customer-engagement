---
title: "Import contacts (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 476018f9-e481-46ba-a9d1-c87cb4dd810a
caps.latest.revision: 60
author: mduelae
ms.author: mkaur
manager: kvivke
search.audienceType: 
  - enduser

---
# Import contacts

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Import data](/powerapps/user/import-data)

Whether your contacts are stored in an email program, a spreadsheet, or on your phone, here's how to import them into Dynamics 365 Customer Engagement (on-premises) so you have all your business contact information in Customer Engagement (on-premises).  
  
## Step 1: Get your import file ready  
First, you export your contacts into a file. These file formats are supported:  
  
-   Comma-separated values (.csv)  
  
-   Text (.txt)  
  
-   Compressed (.zip)  
  
-   Excel Spreadsheet 2003 (.xml)  
  
The maximum file size allowed for .zip files is 32 MB. For the other file formats, the maximum file size allowed is 8 MB.  
  
> [!TIP]
>  If you store contacts in more than one program, add your import files to a single .zip file. Then import the .zip file to bring in all the files at once.  
  
Next, follow the procedure for the program or location where your contacts are stored.  
  
### Export contacts from an email program  
  
1.  Export the contacts into a comma separated values file (.csv).  
  
     To find specific steps to export contacts from your email program, open the program's Help, and search for "export." Look for topics that include "exporting contacts" or "exporting your address book" or "export wizard" in the title.  
  
2.  Save the file in a location where you can find it easily later.  
  
### Export contacts from a spreadsheet  
  
1.  Open the spreadsheet.  
  
2.  If necessary, edit any column name in the spreadsheet to match exactly with the corresponding name shown here.  
  
    > [!WARNING]
    >  If the spreadsheet doesn't include all the column names listed, that's okay. However, if a column name does exist, it must match exactly with the corresponding name in the list or the import won't work. Spaces are required. Note that the word "Email" doesn't contain a hyphen.  

    |**Column Name in Spreadsheet (spelling must match exactly)**|
    |---------|
    |First Name|  
    |Middle Name|  
    |Last Name|  
    |Business Phone|  
    |Mobile Phone|  
    |Job Title|  
    |Business Street|  
    |Business City|  
    |Business State|  
    |Business Postal Code|  
    |Business Country/Region|  
    |Email Address|  
  
3.  Save the file.  
  
### Export contacts from your phone  

Use a USB cable or an app to export your contacts from your phone to your computer.
  
To find specific steps to export contacts for your brand of phone, search for "export contacts from my phone" in your favorite search engine (like [!INCLUDE[pn_bing](../includes/pn-bing.md)]).  
  
To find an app, search your phone's online store.  
  
## Step 2: Import the file  
 You'll use the **Import Data** wizard to import your contacts.  
  
1. Go to **Settings** > **Data Management** > **Imports**.
  
2. On the command bar select **Import Data** > **Import Data**.
    
3. . Browse to the folder where you saved the file that contains the export of your contacts. Select the file, and then select **Open**. select **Next**.  
  
   > [!TIP]
   >  You can import only one file at a time. To bring in more files, run the wizard again later, or add all your contacts files to a single .zip file.  
  
4. Review the file name, and if the file is in .csv or .txt format, verify that the field and data delimiters are correct. Select **Next**.  
  
   > [!NOTE]
   >  In most cases, you can accept the default delimiters.  
  
5. Select **Default (Automatic Mapping)** for the System Data Map. Select **Next**.  
  
6. In the Dynamics 365 Customer Engagement (on-premises)**Record Types** drop-down list, select **Contacts**. Select **Next**.  
  
7. For any record type with an alert icon, map the column from your contacts file to the corresponding field in Dynamics 365 Customer Engagement (on-premises). Select **OK**, and then select **Next**.  
  
8. Review the summary, and then select **Next**.  
  
9. Select **Submit**.  
  
10. To verify that the wizard was successful, select **Imports**, then review the report. Otherwise, select **Finish**.  
  
## Step 3: Check that the contacts imported successfully  
 After the wizard finishes, check your list of contacts to make sure they imported correctly.  
  
1. Select your role (either Sales, Service, or Marketing). [!INCLUDE[proc_contacts](../includes/proc-contacts.md)]  
  
2. Scroll through the contact list. Check that each person is listed and verify the contents of the fields for accuracy.

3. If needed, learn about removing duplicates: [Merge duplicate records for accounts, contacts, or leads](merge-duplicate-records-accounts-contacts-leads.md).  
  
### See also  
 [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)    



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]