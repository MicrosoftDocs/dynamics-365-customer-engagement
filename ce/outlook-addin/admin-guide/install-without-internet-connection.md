---
title: "Install Dynamics 365 for Outlook without an Internet connection | MicrosoftDocs"
ms.custom:
ms.date: 11/28/2016
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 723e1196-cd04-4823-bb0d-2e050e2b4acd
caps.latest.revision: 42
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Outlook
---
# Install Dynamics 365 for Outlook without an Internet connection
There may be occasions when you have to install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] where there is no Internet connection available. Common occasions are when you are creating virtual demonstration environments, such as when you use [!INCLUDE[pn_Hyper-V](../../includes/pn-hyper-v.md)], and environments that use firewalls or other security requirements that block Internet access.

 To install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] without an Internet connection, you must first download all prerequisite software. To do this, you will need a computer that has an Internet connection to download all the prerequisites beforehand.

 Notice that, when you download the [!INCLUDE[pn_crm_2016_shortest](../../includes/pn-crm-2016-shortest.md)] ISO from MSDN, or have a physical DVD that you are installing from, you will already have all of the prerequisites downloaded. However, if you download the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installation media from the [!INCLUDE[pn_Microsoft_Download_Center](../../includes/pn-microsoft-download-center.md)], you must manually build the prerequisite folder structure.

<a name="BKMK_1_create_redist"></a>
## Step 1: Extract the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installation files
 First, create a folder on your local computer and then download the [Dynamics 365 for Outlook installation package](https://www.microsoft.com/download/details.aspx?id=50370). It doesn't matter what name you give the folder where you extract the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] files.  For example, you can name the folder *CRMforOutlookwithoutInternet*.

 After you complete this step there should be several files and folders under the *CRMforOutlookwithoutInternet* folder you created,  including SetupClient.exe.

<a name="BKMK_2createSub"></a>
## Step 2: Create the dependent and optional software subfolders
 Create the following subfolders under the *CRMforOutlookwithoutInternet* folder that you created in the previous step.

1. dotNETFX

2. ReportViewer

3. SQLCE

4. SQLExpr – Required if you use the Go offline capability with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]

5. SQLExprRequiredSp - Required in order to upgrade SQL Express 2008 to 2012. Not required for a new install of SQL Express 2012.

6. VCRedist

7. VCRedist10

8. WindowsIdentityFoundation

9. SQLSystemCLRTypes

   After you are finished the  *CRMforOutlookwithoutInternet* folder looks similar to this.

   ![Folders for setting up Dynamics 365 for Outlook with no internet](../media/itpro-crm-for-outlook-no-internet-setup.png "Folders for setting up Dynamics 365 for Outlook with no internet")

<a name="BKMK_3download"></a>
## Step 3: Download the prerequisite files
 Download the prerequisite components and copy them into the appropriate subfolders as indicated in the following list.

1. dotNETFX


   |                          Description                           |                            File name and direct download link                             |
   |----------------------------------------------------------------|-------------------------------------------------------------------------------------------|
   | Microsoft .NET Framework 4 (Offline Installer (64 and 32-bit)) | [NDP452-KB2901907-x86-x64-AllOS-ENU.exe](https://go.microsoft.com/fwlink/p/?LinkId=328855) |


2. ReportViewer


   |             Description              |                 File name and direct download link                  |
   |--------------------------------------|---------------------------------------------------------------------|
   | Microsoft Report Viewer 2012 Runtime | [ReportViewer.msi](https://go.microsoft.com/fwlink/p/?LinkId=390736) |


3. SQLCE


   |                  Description                  |                     File name and direct download link                     |
   |-----------------------------------------------|----------------------------------------------------------------------------|
   | Microsoft SQL Server Compact 4.0 SP1 (64-bit) | [SSCERuntime_x64-ENU.exe](https://go.microsoft.com/fwlink/p/?LinkId=253118) |
   | Microsoft SQL Server Compact 4.0 SP1 (32-bit) | [SSCERuntime_x86-ENU.exe](https://go.microsoft.com/fwlink/p/?LinkId=253117) |


4. SQLExpr


   |                                                                            Description                                                                             |                   File name and direct download link                   |
   |--------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------|
   | SQL Express 2012 Express SP2 x86 (32-bit, used by both 64 and 32-bit versions of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]) | [SQLEXPR_x86_ENU.exe](https://go.microsoft.com/fwlink/p/?LinkId=403076) |


5. SQLExprRequiredSp


   |       Description       |                   File name and direct download link                   |
   |-------------------------|------------------------------------------------------------------------|
   | SQL Express 2008 R2 SP3 | [SQLEXPR_x86_ENU.exe](https://go.microsoft.com/fwlink/p/?LinkId=403077) |


6. VCRedist


   |                    Description                     |                 File name and direct download link                  |
   |----------------------------------------------------|---------------------------------------------------------------------|
   | Microsoft Visual C++ 2013 Redistributable (64-bit) | [vcredist_x64.exe](https://go.microsoft.com/fwlink/p/?LinkId=402059) |
   | Microsoft Visual C++ 2013 Redistributable (32-bit) | [vcredist_x86.exe](https://go.microsoft.com/fwlink/p/?LinkId=402042) |


7. VCRedist10


   |                    Description                     |                 File name and direct download link                  |
   |----------------------------------------------------|---------------------------------------------------------------------|
   | Microsoft Visual C++ Redistributable SP 1 (64-bit) | [vcredist_x64.exe](https://go.microsoft.com/fwlink/p/?LinkId=404264) |
   | Microsoft Visual C++ Redistributable SP 1 (32-bit) | [vcredist_x86.exe](https://go.microsoft.com/fwlink/p/?LinkId=404261) |


8. WindowsIdentityFoundation

   |Description|File name and direct download link|
   |-----------------|----------------------------------------|
   |Windows Identity Foundation, Windows 7 (64-bit)|[Windows6.1-KB974405-x64.msu](https://go.microsoft.com/fwlink/p/?LinkId=190780)|
   |Windows Identity Foundation, Windows 7 (32-bit)|[Windows6.1-KB974405-x86.msu](https://go.microsoft.com/fwlink/p/?LinkId=190781)|

   > [!NOTE]
   >  By default, [!INCLUDE[pn_Windows_Identity_Framework_(WIF)](../../includes/pn-windows-identity-framework-wif.md)] is already included with [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)] and [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)].

9. SQLSystemCLRTypes

    |Description|File name and direct download link|
    |-----------------|----------------------------------------|
    |SQLSysClrTypes.msi (64-bit)|[SQLSysClrTypes](https://go.microsoft.com/fwlink/p/?LinkID=188392)|
    |SQLSysClrTypes.msi (32-bit)|[SQLSysClrTypes](https://go.microsoft.com/fwlink/p/?LinkId=390735)|

    > [!IMPORTANT]
    >  After downloading the SQLSysClrTypes.msi file, you must rename it according to the bitness of the client. Rename SQLSysClrTypes.msi to: SQLSysClrTypes_x86.msi for the 32-bit client; SQLSysClrTypes_x64.msi for the 64-bit client.

<a name="BKMK_4RunSetup"></a>
## Step 4: Run [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] Setup
 Now that you have all the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installation files and prerequisites downloaded and saved in the correct folders, you can run [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] Setup (SetupClient.exe) without an Internet connection.



[!INCLUDE[footer-include](../../includes/footer-banner.md)]