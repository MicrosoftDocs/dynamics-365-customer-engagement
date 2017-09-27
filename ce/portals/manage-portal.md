---
title: "Manage a portal for Dynamics 365 | MicrosoftDocs"
description: "Instructions to manage your portal."
ms.custom: ""
ms.date: 09/14/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 265AE063-1D9C-40DD-AAAF-69EAB848F22F
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Manage your portal

After provisioning a portal, you can perform various actions such as setting-up custom domain, importing metadata translations, and so on. This section provides you the information on all the tasks required to manage your portal.

To manage an existing portal, you must be assigned any one of the following roles:
- Office 365 Global Administrator 
- [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Service Administrator. For more information about this role, see [here](https://technet.microsoft.com/en-us/library/mt793847.aspx). 
System Administrator of the Dynamics 365 organization selected for the portal.

If you are not assigned any of the above-mentioned roles, the following message is displayed: “You need to be a global administrator, Dynamics 365 service administrator, or system administrator for this organization in order to manage this portal.”

If you are not a Global Administrator and try to manage an already provisioned portal or resubmit the provisioning if it failed, you must be the owner of the Azure AD Application connected to your Portal. To add yourself as an owner of the application:

1. Go to the Portal Management page. An error message is displayed “You don’t have permission to perform this action. Contact your global administrator to get owner permission for Application ID: [app id] in your Azure Active Directory”.
2. Copy the app ID from the error message.
3. Go to Azure AD associated to your tenant. For instructions to perform this task, see [here](https://docs.microsoft.com/en-us/azure/active-directory/active-directory-manage-o365-subscription).
4. In Azure AD, search for the application using app ID you copied from the error message.
5. Add users or groups as owner of this application. For instructions to perform this task, see [here](https://docs.microsoft.com/en-us/azure/active-directory/active-directory-managing-access-to-apps).

    > [!Note]
    > This task can be performed either by Global Administrator of your organization or the existing owner of this application.

6. Once you have added yourself as an owner, reopen the Portal Admin Center page.

## Link your Dynamics 365 portal to a custom domain

A custom domain can help your customers find your support resources more easily and enhance your brand. Only one custom domain name can be added to a portal. After you have provisioned your portal and acquired your domain name, you will need an SSL certificate to set up a custom host name. You can use the purchased SSL certificate for your domain to link your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal to a custom domain by using a wizard.

1. Go to the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Administration center and select the **Applications** tab.
2. Select the name of the portal for which you want to set up a custom domain, and then select **Manage**.
3. Go to **Portal Actions** > **Add a Custom Domain Name**. A wizard opens to choose the SSL certificate.
4. On the **Choose a SSL certificate** page, select one of the following options:
    - **Upload a new certificate**: Select this option to upload the .pfx file if you have not yet uploaded it to the organization. Select the upload button underneath **File** to select the .pfx file. After selectin the file, enter the password for your SSL certificate in the **Password** field.
    - **Use an existing certificate**: Select this option to choose the correct certificate from the drop-down list. Ensure that you are using a SHA2 certificate; SHA1 support is being removed from popular browsers.
5. Select **Next**.
6. On the **Choose a host name** page, select one of the following options:
    - **Add a new hostname**: Select this option to create a new custom domain. Enter the domain name you want in the **Domain Name** field.
    - **Use an existing host name**: Select this option to choose a host name from the drop-down list. 
   
   > [!Note] 
   > - You can only have one custom domain name for a portal. 
   > - To create a custom host name, you will need to create a CNAME with your domain provider that points your domain to the URL of your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal. If you have just added a CNAME with your domain provider, it will take some time to propagate to all DNS servers. If the name is not propagated and you add it here, this will show a message “Please add a CNAME record to this domain name.” Retry after some time passes.

7. Review the information you have entered, and then select **Next** to begin creating the SSL Binding. You should see the message “Custom Domain name has been successfully configured for this Portal. You can now go to {Custom Domain Name} to access this portal.” {Custom Domain Name} will be a hyperlink to the Custom Portal URL that was just configured.
8. Select **Finish** to close the wizard.

    > [!Note]
    > If you want to change your existing custom domain name, you must upload a new SSL certificate and follow the steps in the wizard as mentioned [here](#link-your-dynamics-365-portal-to-a-custom-domain).
    
## Import metadata translation
When you provision a portal, the portal-related solutions are installed on the organization. During the installation of solutions, the solution metadata translations (for example, Field name, form name, and view name) are installed only for the languages currently activated in the organization. If you activate a new language in the future, the metadata is not installed automatically for the newly activated language. To get the metadata translation for the newly activated language, you must import metadata translation from the Administration Center.

To import metadata translation:
1.	Go to the **Dynamics 365 Administration Center** page and select the **Applications** tab.
2.	Select the name of the portal in which you want to import metadata translation, and then select **Manage**.
3.	Go to **Portal Actions** > **Get latest metadata translations**. A confirmation window is displayed asking whether to update the portal solutions.
4.	Select **Update**. The portal solutions will be updated with the latest metadata translation.

> [!Note]
> - If the latest version of a portal package is available, it is not updated. The portal solutions are updated in the same version. To upgrade your portal solutions based on the latest available packages, you need to access the Solution Admin center.
> - If a user has modified any data in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], the existing data is not overwritten during the update.
> - If the portal solutions are being installed, the solution update cannot be triggered.