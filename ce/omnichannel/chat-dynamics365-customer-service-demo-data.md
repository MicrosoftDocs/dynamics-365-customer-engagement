---
title: "Demo data installation for Chat for Dynamics 365 Customer Service | MicrosoftDocs"
description: "Demo data installation for Chat for Dynamics 365 Customer Service"
keywords: ""
ms.date: 10/18/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
ms.assetid: 7AA7A90A-3F40-47A3-9DD0-2BE62A3781E0
author: kabala123
ms.author: kabala
manager: shujoshi
---


# Demo data installation for Chat for Dynamics 365 Customer Service

This topic describes instructions to install sample/demo data for Chat for Dynamics 365 Customer Service capabilities to help you build your own demo environments.

The sample data is available as a downloadable demo package, which you can install in your Omnichannel for Dynamics 365 Customer Service demo environment.
<!--note from editor: Is the reference in the above sentence to Omnichannel correct? Or should it also be Chat for Dynamics 365 Customer Service? -->

> [!IMPORTANT]
> - Once installed, you can't uninstall the demo data. 
> - The Chat for Dynamics 365 Customer Service demo data is available only in English. 
> - Install the demo data on a demonstration, evaluation, training, or test environment. We do not recommend installing the demo data in production environments.

## Requirements

The following are the requirements to install sample data in your target environment:

- Latest version of Common Data Service platform
- Base language is English
- The environment has no Omnichannel for Customer Service data already, or has only the default data that comes with a new org
- The correct version of the business application is already installed Chat for Dynamics 365 Customer Service 
<!--note from editor: The sentence above is not clear. What business application? And do you mean "...is already installed FOR Chat for Dynamics 365 Customer Service"?-->
- The org has Omnichannel for Customer Service provisioned and the Chat channel is enabled.

> [!NOTE]
> If you need to install the demo data on top of an existing Chat trial or a demo environment that already has data (not recommended), you'll need to suspend the safety prechecks performed by the installer. For more information, see the [Technical notes](#technical-notes).

## Download the sample data

Download the demo data from the Download Center and save it on your computer.

[Chat for Dynamics 365 Customer Service demo data](https://go.microsoft.com/fwlink/p/?linkid=2026536)
<!--note from editor: When you use a fwlink URL, do not include anything after the linkid. That locks it into using one language only, the same as if you used en-us.-->


## Extract files

The Chat demo data installer is a self-extracting executable file. After you download the demo data, perform the following steps:

1. Run the **.exe** file that you downloaded.

2. Accept terms and conditions to unpack the compressed zip file. 

3. Extract the contents of that file to a folder on your computer.

Depending on the operating system and security settings, you may need to perform the following steps after unpacking the zip file:

1. Open the **OmnichannelDemoDataPackage** folder.
<!--note from editor: Are the file names used in this step and the next one still accurate, given that the name of this demo data has changed to be about the Chat add-in? This is a global question. If you change it here, please change it everywhere needed. -->

2. Right-click the **OmnichannelDemoDataPackage.dll** file and choose **Properties**.

3. Choose **Unblock**.

    > [!div class=mx-imgBorder] 
    > ![Select unblock](media/omnichannel-sample-data-2.png "Select unblock")

4. Select **Apply**.

5. Select **OK**.

## Set up users

The OmnichannelDemoData package installs with a few users per the settings described below.
<!--note from editor: There are no settings described below. Do you mean "...includes the sample users listed in the table below."? -->

To install the demo data, you need to create (or temporarily rename) users in your Common Data Service platform to match the incoming demo data configuration.
<!--note from editor: The sentence above says you need to create or rename users, but the steps below just swap out the full name for the user alias and then apply roles to the user. This is not consistent. -->

| First Name | Last Name | User Alias   | Email                                    | Role                      |
|------------|-----------|--------------|------------------------------------------|---------------------------|
| Alex       | Allman    | alexallman   | <alexallman@sampleorg.onmicrosoft.com>   | Omnichannel Supervisor    |
| Lilly      | Michael   | lillymichael | <lillymichael@sampleorg.onmicrosoft.com> | Omnichannel Administrator |
| Penelope   | Mayo      | penelopemayo | <penelopemayo@sampleorg.onmicrosoft.com> | Omnichannel Agent         |

<!--note from editor: In this table, Lilly has just one role listed. But in the procedure below, you add 2 roles to her user page. Which is correct? -->

<!--note from editor: I was told that the names used in this article are approved fictitious names. However, the email addresses are not approved sample email addresses from the CELA website. They also use firsta and last names, but the CELA guidelines say to use just first names. Was the email address domain "sampleorg.onmicrosoft.com" used above approved as part of the Chat sample data? If not, they need to be changed to use approved sample data. -->

### Configure users

1. Sign in to the Common Data Service platform.

2. Select **Settings** > **Security** > **Users**.

3. Replace `"Lilly Michael"`with `"lillymichael"` in the `UserFullname="Lilly Michael"` tag. Ensure the username is all lowercase.
<!--note from editor: This step is confusing. Why would you replace the full name and then in the next step tell people to select the Lilly Michael user? It also doesn't apply the change in any way that's noted, like clicking Save or Apply, so it's not clear why this is necesseary. Is this step out of order? -->

4. Select the **Lilly Michael** user. The user page appears.

5. Select **Manage Roles** in the command bar at the top. The **Manage User Roles** dialog box appears.

6. Select the check box for the following role names: 

    - **System Administrator**
    - **Omnichannel Administrator**

7. To grant full admin rights to Lilly Michael, select **OK**.

    This ensures that demo data records are created with the correct user ownership and therefore populate views correctly.
    <!--note from editor: Are there more users to do this to? There are more users listed in the table above. Are people supposed to repeat steps 1-7 for all the other users in the table? -->

### Update data mapping file

Next you need to update a data mapping file with the email address of the default user context in the downloaded package.

1. Open **PkgFolder**.

2. Open the **usermap.xml** file in Notepad (or another XML editor).

3. Set the `DefaultUserToMapTo=` field to the Lilly Michael user's email address. 

    For example: `<MappingConfiguration DefaultUserToMapTo="lilymichael@sampleorg.onmicrosoft.com">`

4. Select **Save**.

> [!TIP]
> We recommend creating a backup of your environment so you can revert to the initial stage if you encounter issues during the demo data installation. To learn more, see [Back up and restore instances](/admin/backup-restore-instances).

## Run the Package Deployer

When you install any of the demo data, the following actions occur during the installation process:

- Default parameters for using Omnichannel for Customer Service are created and/or set.
- Demo data and configuration for the applications are imported (Chat widget, Work Streams, Queues, and other entities) to demonstrate key capabilities.

Wondering what capabilities you can demo with the demo data? See the Fabrikam scenario below.
<!--note from editor: Add a bookmark to the Fabrikam scenario section. -->
<!--note from editor: I moved all the Important alerts to the top of the article. It's better to tell people those things before they begin doing the steps. -->

1. Open the **OmnichannelDemoData** folder.

2. Run **PackageDeployer.exe**.

3. Accept the terms and conditions.

4. Specify the following in the connect screen and select **Login**. In this step, you need to connect to the Common Data Service environment where you want to deploy the demo data:
<!--note from editor: If the UI says Login, then you must use it. However, we stopped using that term years ago. Can you please share that information with the PM? Here is the MSWG guideline: https://styleguides.azurewebsites.net/Styleguide/Read?id=2700&topicid=33573 -->


    | Field | Value |
    |-------------------------|------------------------|
    | Deployment Type | Office 365 | To connect to a Common Data Service environment. |
    | Display list of available organizations | Select the check box. |
    | Show Advanced | Select the check box. |
    |  Online Region | Select the organization that you want to connect to. |
    | User Name | Specify the user name of the system administrator user that you configured in the [Configure users](#configure-users) section. <br> For example: <br> `lilymichael@sampleorg.onmicrosoft.com` |
    | Password | Specify the password of the system administrator user that you configured in the [Configure users](#configure-users) section. |

    ![Dialog box for connecting to an environment](media/omnichannel-sample-data-3.png "Dialog box for connecting to an environment")


5. Select **Next** in the subsequent screens until you see the **Demo Data Setup** dialog box.

    ![Reading demo data](media/omnichannel-sample-data-4.png "Reading demo data")
    
<!--note from editor: The name of the dialog box that is in the image does not at all match the name "Demo Data Setup" in this step. Please fix this to match once you get the new images.-->

6. To start the demo data installation, select **Next**.
    
7. After the demo data is installed successfully, select **Finish**.

    ![Demo data is installed successfully](media/omnichannel-sample-data-5.png "Demo data is installed successfully")
    <!--note from editor: Given that the product name is misspelled in this image and the Finish button is easy to find on the page, I suggest deleting this image and not using it at all. -->

## Verify demo data installation

Verify the number of records and types of entities listed in **Fabrikam** fictitious scenario appear as expected as a sanity check.

After the demo data completely loads, do the following:

1. Sign in to Omnichannel for Customer Service as the Lilly Michael user.
<!--note from editor: The step above did not make sense. I tried to fix it. -->

2. Verify the following:

    - Go to **Omnichannel Administration** > **Queues & Users** > **Users** to
        confirm the three Omnichannel users are created.
    
    - Go to **Omnichannel Administration** > **Queues & Users** > **Queues** to
        confirm the Queue 1 (sample) and Queue 2 (sample) are created.
    
    - Go to **Omnichannel Administration** > **Channels > Chat** to confirm
        the Portal Chat (sample) is created.
    
    - Go to **Omnichannel Administration** > **Work Distribution Management > Work Streams** to confirm  the Chat Push (sample) is created.

## Technical notes
<!--note from editor: Originally I thought this section should be renamed. Then I realized the 3 sections under it are meant to be the notes. So, I made them H3s instead of H2s and gave the first section about environments that already have demo data a heading, because it didn't have one.-->

### Install demo data in an environment that already has data
> [!Warning]
> We highly recommend that you do not install demo data on top of existing data because in order to do so, you have to remove safety precautions.

If you absolutely must install demo data on top of an existing Omnichannel for Customer Service trial or demo environment that already has data, you'll need to suspend the safety prechecks performed by the installer. 

To suspend the safety prechecks, follow these steps:

1. Go to the **PkgFolder** folder.

2. Open the **DemoDataPreImportConfig.xml** file with Notepad (or another XML
    editor).

3. Set the value of `TerminateOnPreCheckFailure` from true to false.

    `<TerminateOnPreCheckFailure>false</TerminateOnPreCheckFailure>`

This change causes the installer to skip safety prechecks, which includes confirming that there is one active **Organizational Unit** record, and then renaming it to **Fabrikam**.
<!--note from editor: None of the steps before this one have said to rename anything to Fabrikam. It is very confusing to add that here. I suggest deleting the mention to Fabrikam. If not, then you must add the steps you are referring to when you say it should be renamed.-->

### Configuration components

There are several configuration components in this pre-import configuration
file. For technical users, these include:

- **<RequiredSolutions\>**: Specifies prerequisite solution installations and their version numbers.

- **\<InstallSampleData\>**: Installs demo data to Common Data Service platform. This is the same demo data that you can install from **Settings** > **Data Management**.

- **\<DefaultParameterDescription\>**: Specifies the default description for the parameters.

### Fabrikam Scenario
<!--note from editor: The addition of this scenario is confusing. You don't use it above as part of the email addresses nor do you use it to explain why the users in the table are there. Then in this section, the scenario doesn't really wrap up. It just kind of ends with a list of demo data that it does not appear needs to be associated with any scenario at all. You could just say at the beginning that the demo data includes these things. I suggest you consider removing the scenario altogether. If not, then please make it a complete scenario that is woven throughout the article.-->

The fictional company, Fabrikam, is a manufacturer of electronic device assembly line of robots and is known for their product quality, innovation, and solid customer service, including: installation planning, implementation, and ongoing
maintenance services. Fabrikam is headquartered in the United States (Fabrikam,
U.S.), and has Customer Service Support operations centered in the United States, primarily in the greater Seattle area. The CSS contact center is focused on providing excellent support experiences to their customers.

A high-level overview of the Chat for Dynamics 365 Customer Service demo data are as follows:

- Three Omnichannel users

- One web customer

- One case

- Four sessions

- One Chat for Dynamics 365 Customer Service workstream

- One Chat widget

- One Omnichannel for Customer Service queue

## See Also

[Omnichannel For Customer Service
Guide](https://docs.microsoft.com/dynamics365/customer-engagement/omnichannel/omnichannel-customer-service-guide)
