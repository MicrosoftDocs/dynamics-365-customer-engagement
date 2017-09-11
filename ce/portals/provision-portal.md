---
title: "Provision a portal for Dynamics 365 | MicrosoftDocs"
description: "Instructions to provision a portal."
ms.custom: ""
ms.date: 09/11/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 1249d87f-6e5e-4ff0-96a9-82978fcbc87c
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Provision a portal
Portals are websites that you can customize to provide a more personalized experience to your customers, partners, or internal employees. Portals integrate with [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] to show data from Dynamics 365 on the portal. By using portals, you can create a variety of experiences where portal users can perform several tasks. For example:

-   Customers can submit cases and find knowledge articles
-   Partners can see and manage sales opportunities
-   Internal employees can create and see best practices

> [!NOTE]
> - To provision a portal, you must be assigned to the System Administrator role of the Dynamics 365 organization selected for the portal.
> - To manage an existing portal, you must be assigned any one of the following roles:
    > - Office 365 Global Administrator 
    > - [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Service Administrator. For more information about this role, see [here](https://technet.microsoft.com/en-us/library/mt793847.aspx). 
    > - System Administrator of the Dynamics 365 organization selected for the portal.
    
> If you are not assigned any of the above-mentioned roles, the following message is displayed: “You need to be a global administrator, Dynamics 365 service administrator, or system administrator for this organization in order to manage this portal.”

To complete provisioning a portal, after you have purchased a new portal license, return to your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instance.

1.  Go to the [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)] and select the **Applications** tab.
2.  Select the application row titled **Portal Add-On**, and then select **Manage.**
3.  In the **General Settings** section, enter a **Name** for your portal. The **Name** will help to identify the portal and can be changed later.
4.  The **Type** field represents the type of portal subscription (Trial or Production). This is a system field, so it cannot be changed by the user. The value changes based on whether it is trial subscription or paid subscription.
5.  In the **Portal URL** field, enter the subdomain name you want for your portal. You may only use alphanumeric characters or hyphens (-); other characters are not permitted. After the portal is provisioned, the URL cannot be changed, but you can use a custom domain name.
6.  Use the **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Instance** drop-down list to choose which [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instance you want to link the portal to. Requires System Administrator or System Customizer role in the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instance you pick to select it.
7.  Choose the default language for your portal from the **Select Portal Language** drop-down list. The available languages will depend on the languages that are installed in your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] instance. 

    >[!NOTE]
    > Sample data is only provided in one language, so choosing a default language will also decide how the sample data is translated. Arabic and Hebrew are not supported and will not appear in the list.

8. In the **Select Portal Administrator** drop-down list, select the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] user who will configure, customize, and maintain the portal. All [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] users who have the System Administrator role in the organization will appear as options. 
9. In the **Portal Audience** section, choose the type of audience who will visit the new portal. This will determine what options of portals you will be given. You can choose:

    -   Partner    
        -   Customer Self Service Portal
        -   Custom Portal
        -   Partner Portal
        -   Partner Project Service (Optional, requires solutions installed)
        -   Partner Field Service (Optional, requires solutions installed)
        -   Community Portal
    
    -   Customer
        -   Customer Self Service Portal
        -   Custom Portal
        -   Community Portal
    
    -   Employee
        -   Employee Self Service Portal

The table below summarizes the features associated with each portal option:


| Feature                                | Customer Self-Service Portal | Partner Portal | Employee Self-Service Portal | Community Portal | Custom Portal |
|----------------------------------------|------------------------------|----------------|------------------------------|------------------|---------------|
| World Ready                            | •                            | •              | •                            | •                | •             |
| Multi-Language Support                 | •                            | •              | •                            | •                | •             |
| Portal Administration                  | •                            | •              | •                            | •                | •             |
| Customization and Extensibility        | •                            | •              | •                            | •                | •             |
| Theming                                | •                            | •              | •                            | •                | •             |
| Content Management                     | •                            |                | •                            | •                |               |
| Knowledge Management                   | •                            | •              | •                            | •                |               |
| Support/Case Management                | •                            |                | •                            | •                |               |
| Forums                                 | •                            |                | •                            | •                |               |
| Faceted Search                         | •                            |                | •                            |                  |               |
| Profile Management                     | •                            |                | •                            |                  |               |
| Subscribe to Forum Thread              | •                            |                | •                            |                  |               |
| Comments                               | •                            |                | •                            | •                |               |
| [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] AD Authentication                |                              |                | •                            |                  |               |
| Ideas                                  |                              |                |                              | •                |               |
| Blogs                                  |                              |                |                              | •                |               |
| Project Service Automation Integration |                              | •              |                              |                  |               |
| Field Service Integration              |                              | •              |                              |                  |               |
| Partner Onboarding                     |                              | •              |                              |                  |               |
| Portal Base                            |  •                           | •              |  •                           | •                | •             |
| Portal Workflows                       |  •                           | •              |  •                           | •                | •             |
| Web Notifications                      |  •                           | •              |  •                           | •                | •             |
| [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Identity                     |     •                         |  •              |     •                         |   •               | •             |
| Identity Workflows                     | •                            |  •             |     •                         |   •               | •             |
| Web Forms                              |  •                            | •               |    •                          | •                 | •             |
| Feedback                               |   •                           |  •              |  •                            | •                 | •             |
||
10. In the **Select portal to be deployed** section, choose what type of portal you want to create. The options you see are based on the audience you selected.

    ![Configure settings for your portal](media/configure-settings-portal.png "Configure settings for your portal")  

11. Select **Submit**, and accept the Terms of Service.

    ![Terms of service](media/terms-of-service.png "Terms of service")  

After you accept the Terms of Service, the portal will begin provisioning. Provisioning usually takes 30 minutes but can take a few hours depending on the system load. The *Name* of the portal on the Application tab will change to “*Name*-Configuring” while it is provisioning. Navigate back to the portal management page to check whether provisioning has succeeded.

> [!Note]
> When a portal user signs in to the portal for the first time using an Azure AD credential, a consent page is displayed to all users irrespective of the user or portal type.

## Troubleshoot Provisioning

Sometimes the package installation process or URL creation process can error out. In these cases, the processes can be restarted.

If “*Name*-Configuring” changes to “*Name*-Provisioning Failed,” you need to restart the provisioning process.

1. Go to the **Applications** page and select the portal.
2. Select the blue pencil button labeled **Manage**.
3. Choose one of the following options:

    -   **Restart Provisioning**: Restarts the installation process with the configuration that was previously defined.

    -   **Change Values and Restart Provisioning**: Lets you change some of the values before restarting the provisioning process.

    ![Provisioning error](media/error-provisioning.png "Provisioning error")  

If the package installation has failed, the portal administrator page will open without any issues, but navigating to the actual portal URL will show a message “Getting set up.” To confirm this:

1. Go to the Solution Management page of the [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)] and check that the package status is “Install Failed.” 
2. If the package status is “Install Failed,” try retrying the installation from the solution page. Also, be sure to check that a system administrator in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] is installing the solution with the default language in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] set to the language the portal should be installed in.

> [!Note]
> Some solutions have prerequisites for their installation, so an installation will fail if the prerequisites are not met. For example, to install the Partner Field Service for a partner portal, the Partner Portal and Field Service solutions must have already been installed. If you attempt to install the Partner Field Service first, the installation will fail and give you an error message.

## Set up custom domains and SSL certificates for a [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal

A custom domain can help your customers find your support resources more easily and enhance your brand. Only one custom domain name can be added to a portal. After you have provisioned your portal and acquired your domain name, you will need an SSL certificate to set up a custom host name.

![Set up a custom domain](media/setup-custom-domain.png "Set up a custom domain")  

1. Go to the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Online Admin center and select the **Applications** tab.
2. Select the name of the portal you want to set up a custom domain for, and go to **Manage** > **Portal Actions** > **Add a Custom Domain Name**.

## Link your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal to a custom domain
You can use the purchased SSL certificate for your domain to link your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal to a custom domain by using the wizard.

1. Select **Upload a new certificate** if you have not yet uploaded the .pfx file to the organization. 
2. Select the upload button underneath **File** and select the .pfx file. 
3. Enter the password for your SSL certificate in the **Password** field. Otherwise select **Use an existing certificate** and choose the correct certificate from the drop-down menu. Be sure that you are using a SHA2 certificate; SHA1 support is being removed from popular browsers.
4. Select **Add a new hostname** to create a new custom domain. Enter the domain name you want into the **Domain Name** field. Otherwise, select **Use an existing host name** and choose the host name you want from the drop-down menu. 

   > [!Note] 
   > - You can only have one custom domain name for a portal. 
   > - To create a custom host name, you will need to create a CNAME with your domain provider that points your domain to the URL of your [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal. If you have just added a CNAME with your domain provider, it will take some time to propagate to all DNS servers. If the name is not propagated and you add it here, this will show a message “Please add a CNAME record to this domain name.” Retry after some time passes.

5.  Review the information you have entered, and then select **Next** to begin creating the SSL Binding.
6.  You should see the message “_Custom Domain name has been successfully configured for this Portal. You can now go to {Custom Domain Name} to access this portal._” {Custom Domain Name} will be a hyperlink to the Custom Portal URL that was just configured. Select **Finish** to close the wizard.

    ![Choose the SSL certificate](media/choose-ssl-certificate.png "Choose the SSL certificate")  
    
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

## View activity of a user on a Portal
Dynamics 365 for Customer Insights (DCI) is a cloud-based SaaS service that enables organizations of all sizes to bring together data from multiple sources and generate knowledge and insights to build a holistic 360° view of their customers.

You can enable a portal to send data from a user’s activity to your DCI instance. This will be helpful in knowing the user’s journey on a portal before and after creating a case. This also helps you to understand the real issue, avoid asking the same information again from the user, and enable you to respond with the relevant information.

Let’s take the following scenario:

Jay is the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] administrator and he is interested in knowing the activity of the portal users before the case is submitted. Jay purchases a DCI instance from Azure portal by using his own subscription plan. Jay then navigates to the Portal Admin Center and configures his portal to use the DCI instance he purchased.

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals needs the latest shared access key to send the interactions to DCI. Jay navigates to the Portal Admin Center and he can see the currently configured DCI instance. Jay can change the DCI instance or update the shared access key for the currently configured DCI instance.

To view activity of a user on a portal:
1.	Go to the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Administration Center page and select the **Applications** tab.
2.	Select the name of the portal you want to view user’s activity, and then select **Manage**.
3.	Select **Portal Analytics**. The Tracking Portal Interaction page is displayed.
4.	Select **Configure Portal Interaction Tracking**. The Configure Portal Interaction Tracking window is displayed.
5.	Enter the following values as per your Dynamics 365 Customer Insights instance:
    - [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] for the Customer Insights hub URI 
    - Policy name with Manage, Read, and Write permissions 
    - Shared Key
6.	Read the preview agreement and select the **I have read and understood the terms and conditions** check box.
7.	Select **Configure**. A progress window is displayed.
8.	Select **Close** in the confirmation window.

After DCI is configured on a portal, the following actions become available:
- **Update D365 Customer Insights configuration**: Allows you to update the shared key related to your policy. The hub URI is read-only.
- **Delete D365 Customer Insights integration**: Allows you to delete the connection configuration between your DCI and your portal.

### Configure DCI
To persist interactions in a customer’s DCI, the portal needs to create the interaction-related configuration in DCI. These interactions need to be tied against a DCI Profile.

> [!Note]
> [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] supports multiple portals, and they can use the same DCI instance.

A portal user can view knowledge articles, blogs, forum threads, and portal search exposed on the portal.

To allow a seamless experience, the following interactions are captured in DCI:


|Interaction name   |Display Name   |Fields   |Description   |Parameters captured|
|---|---|---|---|---|
|portal\_viewknowledgearticle |Knowledge article   |portal\_interactionid, portal\_knowledgearticleid, portal\_knowledgetitle, portal\_contactid, portal\_timestamp,  portal\_portalid |Tracks portal users viewing a knowledge article   |Knowledge article id, language, session id, portal id |
|portal\_viewblogpost   |Blog post   |portal\_interactionid,portal\_blogpostid, portal\_blogtitle, portal\_contactid, portal\_timestamp, portal\_portalid   |Tracks portal users viewing a blog post   |Blog post id, session id, portal id |
|portal\_viewforumthread   |Forum thread   |portal\_interactionid,portal\_forumthreadid, portal\_forumthreadtitle, portal\_contactid, portal\_timestamp, portal\_portalid   |Tracks portal users viewing a forum thread   |Forum Thread id, session id, portal id |
|portal\_search   |Portal Search   |portal\_interactionid, portal\_contactid, portal\_searchstring, portal\_timestamp, portal\_portalid   |Tracks portal users’ searches.   | |
||

As a Portal Administrator, you can configure which interaction gets ingested into DCI through portals as per the customer’s requirement. To prevent a specific interaction being captured by a portal, you can delete the interaction type from DCI.

A portal persists all its data in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. All the data required to render content on the portal comes from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. Data in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] will be used to model profiles and the portal interactions will be tied to it. Portals will not create custom profiles. As a Portal Administrator, you must manually connect this [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization to DCI and create profiles. You need to configure the Contact entity as a profile and then link the Contact to the portal interactions, using the `crmrecordid` which is persisted as `portal_contactid` in the portal interactions. After creating profiles, the administrator must manually link the profiles to the portal interaction type. This will allow the administrator to create charts and profile views.

[!include[More information](../includes/proc-more-information.md)] [Set up Customer Insights](https://docs.microsoft.com/dynamics365/customer-insights/deploy/stepbystepconfiguration)

### Visualize the customer journey
Visualizing a customer journey allows you to view the user’s activity in chart format. This tells you what activities a user has already performed before submitting the case, so you can provide relevant information.

Let’s take the following scenario:

Sharron is the CSR executive working on the cases in Contoso, Ltd. Sharron frequently helps her customers resolve customer issues by sharing the link to knowledge articles in the `http://support.contoso.com` self-service portal. At times, Sharron shared the same articles her customers had already read, which resulted in poor customer satisfaction. 

The Customer Journey chart is embedded on the Case form, which displays the portal user’s activity moments before the case was created. This helps Sharron share relevant information that helps resolve the issue in a more effective way.

[!include[More information](../includes/proc-more-information.md)]  [Set up Customer Insights](https://docs.microsoft.com/dynamics365/customer-insights/deploy/stepbystepconfiguration)



