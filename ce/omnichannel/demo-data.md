---
title: "Demo data installation for Omnichannel for Customer Service | MicrosoftDocs"
description: "Demo data installation for Omnichannel for Customer Service"
keywords: ""
ms.date: 10/14/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
ms.assetid: 3ab5c130-aae8-6717-22cf-cf7fe0cf4168
author: kabala123
ms.author: kabala
manager: shujoshi
---


# Demo data installation for Omnichannel for Dynamics 365 Customer Service

This topic describes instructions to install sample/demo data for Chat for Dynamics 365 Service capabilities to help you build your own demo environments.

The sample data is available as a downloadable demo package, which you can install in your Omnichannel for Dynamics 365 Customer Service demo environment. 

- [Omnichannel Demo Data](https://go.microsoft.com/fwlink/?linkid=2026536&clcid=0x409)


> [!IMPORTANT]
> Once installed, demo data can't be uninstalled. Also, the Demo data package is only available in English. Only install the package on demonstration, evaluation, training, or test systems.

When installing any of the Demo data packages, the following actions occur during the installation process:

- Default parameters for using Omnichannel are created and/or set.
- Demo data and configuration for the applications are imported (e.g.: Chat
            widget, Work Streams, Queues, and other entities) to demonstrate key
            capabilities.

Wondering what capabilities you can demo with the Demo data? See the Fabrikam scenario below.


## Requirements

The following are the requirements to install sample data in your target environment:

- Latest version of Common Data Service platform
- Base language is English
- The environment has no Omnichannel for Customer Service data already, or only has default data that comes with any new org
- The correct version of the business application is already installed Chat for Dynamics 365 Customer Service 
- The org has Omnichannel for Customer Service provisioned and the Chat channel is enabled.

> [!NOTE]
> If you need to install the Demo data on top of an existing Chat for Dynamics 365 trial or a demo environment that already has data (not recommended), you'll need to suspend the safety prechecks performed by the installer. For more information, see the \<technical notes\> [create jump link].





## Prepare for installation

Installer needs to run on a computer with a recent version of Windows (Windows 10 preferred).

Plan for the computer to remain connected to a network, and installation to run
for up to one (1) hour. (Normally installation takes 15-30 minutes
for **OmnichannelDemoData**, which includes Demo data and configuration for
Chat).

Computer should have a screensaver function turned off, otherwise, session
credentials for the installation may be lost when the screensaver engages
(unless you keep your session active throughout).

![](media/omnichannel-sample-data-1.png)

## Download and unpack

The Omnichannel Demo data installer is distributed as a self-extracting
executable. After downloading a package, run the EXE file, then accept terms and
conditions to unpack the compressed zip file. You then need to extract contents
of that file to a folder on the computer.

Depending on the operating system and security settings, you may need to perform
the following steps after unpacking the zip file:

1. Find and right-click the **OmnichannelDemoDataPackage.dll** file and choose **Properties** in the **OmnichannelDemoDataPackage** folder.
2. Choose **Unblock**.

![](media/omnichannel-sample-data-2.png)

1. Select **Apply**.
2. Select **OK**.

## Create or configure users

The **OmnichannelDemoData** package is designed to install with a few users per the settings described below:

To install the package correctly, you need to create (or temporarily rename)
users in your Dynamics 365 for Customer Engagement to match the incoming Demo
data configuration.

| First Name | Last Name | User Alias   | Email                                    | Role                      |
|------------|-----------|--------------|------------------------------------------|---------------------------|
| Alex       | Allman    | alexallman   | <alexallman@sampleorg.onmicrosoft.com>   | Omnichannel Supervisor    |
| Lilly      | Michael   | lillymichael | <lillymichael@sampleorg.onmicrosoft.com> | Omnichannel Administrator |
| Penelope   | Mayo      | penelopemayo | <penelopemayo@sampleorg.onmicrosoft.com> | Omnichannel Agent         |

To create or configure users, go to **Settings** \> **Security** \> **Users**, and do the following:

1. Set UserFullname="Lilly Michael" with username "lillymichael" (**lowercase**).
2. Select the **Lilly Michael** user, and then select **Manage Roles**.
   - Find and select the, **System Administrator** and **Omnichannel Administrator** role.
   - Select **OK** to grant full admin rights to Lilly Michael.

>   This step is necessary to ensure that demo records are created with the
>   correct user ownership and therefore populate views correctly.

1. From the downloaded package, you need to update a data mapping file with email addresses of the default user context. To do this:
   - Open **PkgFolder**
   - Open **usermap.xml** file in Notepad (or Visual Studio or another XML editor).
   - Set **DefaultUserToMapTo=** field to the email address of the Lilly Michael user. Example: \<MappingConfiguration DefaultUserToMapTo=" "\>

>   **Recommendation:**  Consider creating a backup of your org now, in case you
>   need to revert to your starting point if something goes wrong during the
>   Demo data installation. See [Backup and restore
>   instances](https://docs.microsoft.com/dynamics365/customer-engagement/admin/backup-restore-instances)
>   for more information.

## Run the Package Deployer

1. Find and run the **PackageDeployer.exe** in the **OmnichannelDemoData** folder.
2. Accept the terms and conditions.
3. On the next window:

    1. Select deployment type **Office 365**.
    2. Enter the user and password of the system administrator user configured
        in "Create or configure users" (e.g.: "Spencer Low" with "spencerl"
        username).
    3.  Ensure **Display list of available organizations** is selected.

![](media/omnichannel-sample-data-3.png)

1. Select the Dynamics 365 for Customer Engagement organization where you want
    to install the Demo data.

2. Select **Next** until you see the **Demo Data Setup** dialog.

![](media/omnichannel-sample-data-4.png)

>   Machine generated alternative text: Ommchannle Demo Data Package Setup for
>   Microsoft Dynamics CRM Reading Omnichannle Demo Data Package Installer
>   Configuration Status: Ready Organization : orggl 19007d View log file Import
>   configuration loaded. Found I solutions. Found the solution:
>   OmnichanneIDemoData, version: 1.4.0.589 (Managed) Found the detailed data to
>   import. Initializing 5 connection threads for detailed data import. Previous

1. Before proceeding, note that installing Demo data could take up to one hour
    (normally \~10 minutes). You'll need to make sure the computer remains on
    and connected to a network throughout the installation process, and your
    session remains active.

2. When ready, click **Next** to start the Demo data installation process.
    After the Demo data is loaded, click **Finish**.

![](media/omnichannel-sample-data-5.png)

>   Machine generated alternative text: Omnichannle Demo Data Package Setup for
>   Microsoft Dynamics CRM Installation Complete Microsoft Dynamics 365
>   Omnichannle Sample Data - Import Completed Omnichannle Data Package Data
>   package for Omnichannel for Customer Service and Chat for Dynamics 365 have
>   been imported successfully. Finish

## Verify the Demo data installation

Verify the number of records and types of entities listed in Fabrikam fictitious
scenario appear as expected as a sanity check.

After the Demo data completely loads, sign in as the Lilly Michael user and
confirm the following:

- Go to **Omnichannel Administration** \> **Queues & Users** \> **Users** to
    confirm the three Omnichannel users are created.

- Go to **Omnichannel Administration** \> **Queues & Users** \> **Queues** to
    confirm Queue 1 (sample) and Queue 2 (sample) are created.

- Go to **Omnichannel Administration** \> **Channels \> Chat** to confirm
    Portal Chat (sample) is created.

- Go to **Omnichannel Administration** \> **Work Distribution Management \>
    Work Streams** to confirm Chat Push (sample) is created.

## Technical notes

See below for more technical details on the installation of this data.

**Installing Demo data on top of existing data (not recommended)**

If you need to install Demo data on top of an existing Omnichannel trial or demo
environment that already has data, you'll need to suspend the safety prechecks
performed by the installer, to do this:

1. Go to **PkgFolder** folder

2. Open **DemoDataPreImportConfig.xml** file with Notepad (or another XML
    editor).

3. Find the following value, and change setting from true to false:

>   \<TerminateOnPreCheckFailure\>true\</TerminateOnPreCheckFailure\>

>   This change causes the installer to bypass some important safety checks,
>   which includes confirming there is no more than one active **Organizational
>   Unit** record, and then renaming it to **Fabrikam**.

## Configuration components

There are several configuration components in this pre-import configuration
file. For technical users, these include:

- **\<RequiredSolutions\>** specifies prerequisite solution installations and
    their version numbers.

- **\<InstallSampleData\>** installs Demo data to Dynamics 365 instance. This
    is the same Demo data that you can install from **Settings** \> **Data
    Management** area in Dynamics 365.

- **\<DefaultParameterDescription\>** specifies the default description for
    the parameters.

**Fabrikam Scenario**

The fictional company, Fabrikam, is a manufacturer of electronic device assembly
line of robots and is known for their product quality, innovation, and solid
customer service, including: installation planning, implementation, and ongoing
maintenance services. Fabrikam is headquartered in the United States (Fabrikam,
U.S.), and has Customer Service Support operations centered in the United
States, primarily in the greater Seattle area. The CSS contact center is focused
on providing excellent support experience to their customers.

A high-level overview of the Omnichannel Demo data is as follows:

- 3 Omnichannel users

- 1 Web customer

- 1 Case

- 4 sessions

- 1 Omnichannel Chat workstream

- 1 Chat widget

- 2 Omnichannel queues

## See Also

[Omnichannel For Customer Service
Guide](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/omnichannel/omnichannel-customer-service-guide)
