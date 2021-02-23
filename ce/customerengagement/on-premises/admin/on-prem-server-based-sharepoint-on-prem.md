---
title: Configure server-based authentication with Customer Engagement (on-premises) and SharePoint on-premises
ms:assetid: 26cad581-33b0-4025-9964-d289363c4245
ms.date: 10/01/2019
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.author: matp
author: Mattp123
manager: kvivek
---

# Configure server-based authentication with Customer Engagement (on-premises) and SharePoint on-premises

This topic describes how to configure server-based integration between Dynamics 365 Customer Engagement (on-premises) and Microsoft SharePoint On-Premises.

## Set up server-based integration with Customer Engagement (on-premises) and SharePoint

Follow the steps, in the order provided, to set up Customer Engagement (on-premises) with Microsoft SharePoint Server On-Premises.

> [!IMPORTANT]
> <UL>
> <LI>
> <P>If a task isn’t completed, for example, if a PowerShell command returns an error message, the issue must be resolved before you continue to the next command, task, or step.</P>
> <LI>
> <P>Once you enable server-based SharePoint integration, you won't be able to revert to the previous client-based authentication method. Therefore, you can’t use the Microsoft Dynamics CRM List Component after you have configured your Customer Engagement (on-premises) organization for server-based SharePoint integration.</P>
> <P></P></LI></UL>



## Verify prerequisites

Before you configure Customer Engagement (on-premises) and SharePoint On-Premises for server-based integration, the following permissions and prerequisites are required.

## Permissions required

**Customer Engagement (on-premises)**

  - System Administrator security role - this is required to run the Enable Server-Based SharePoint Integration wizard in Customer Engagement (on-premises).

  - If you are using a self-signed certificate for evaluation purposes, you must have local Administrators group membership on the computer where Dynamics 365 Server is running.

**SharePoint On-Premises**

  - Farm Administrators group membership - this is required to run most of the Windows PowerShell commands on the SharePoint server.

## SharePoint prerequisites

  - One of the following SharePoint versions:

      - SharePoint 2019 On-Premises.

        Server-based integration between Dynamics 365 Customer Engagement (on-premises) and Microsoft SharePoint 2019 On-Premises requires [Microsoft Dynamics 365 Server, v9.0 (on-premises) Update 0.13](https://www.microsoft.com/download/details.aspx?id=100875), or later version.
    
      - SharePoint 2016 On-Premises.

      - Microsoft SharePoint 2013 On-Premises with Service Pack 1 (SP1) or later version with the following updates.

          - Install the April 2019 Cumulative Update (CU) for the SharePoint 2013 product family. This April 2019 CU includes all SharePoint 2013 fixes (including all SharePoint 2013 security fixes) released since SP1. The April 2019 CU does not include SP1. You need to install SP1 before installing the April 2019 CU.
            
              - [KB4464512](https://support.microsoft.com/help/4464512/april-9-2019-cumulative-update-for-sharepoint-foundation-2013-kb446451) – SharePoint Foundation 2013 April 2019 CU

              - [KB4464514](https://support.microsoft.com/help/4464514/april-9-2019-cumulative-update-for-sharepoint-enterprise-server-2013-k) – SharePoint Server 2013 April 2019 CU

              - [KB4464513](https://support.microsoft.com/help/4464513/april-9-2019-cumulative-update-for-project-server-2013-kb4464513) – Project Server 2013 April 2019 CU

  - SharePoint configuration
    
      - SharePoint must be configured for a single farm deployment only.
    
      - To use the default claims-based authentication mapping, the Active Directory domain where the SharePoint server and Dynamics 365 Server are located must be the same, or the domain where the SharePoint server is located must trust the domain where the Dynamics 365 Server is located. More information: [About claims-based authentication mapping](#about-claims-based-authentication-mapping)
    
      - The SharePoint website must be configured to use TLS/SSL (HTTPS) and the certificate must be issued by a public root Certificate Authority. More information: [SharePoint: About Secure Channel SSL certificates](/SharePoint/hybrid/plan-connectivity-from-office-365-to-sharepoint-server#aboutsecurechannel)
    
      - The App Management Service Application Proxy must be created and started. More information: [Configure an environment for apps for SharePoint](/SharePoint/administration/configure-an-environment-for-apps-for-sharepoint)
    
      - A User Profile Service Application must be configured and started. More information: [Create, edit, or delete User Profile service applications in SharePoint Server 2013](/SharePoint/install/create-a-user-profile-service-application)
    
      - For document sharing, the SharePoint search service must be enabled. More information: [Create and configure a Search service application in SharePoint Server](/SharePoint/search/create-and-configure-a-search-service-application)
    
      - For document management functionality when using Microsoft Customer Engagement (on-premises) mobile apps, the on-premises SharePoint server must be available through the Internet.
    
      - To allow users the ability to create SharePoint document libraries from Customer Engagement (on-premises), the following permissions and configurations are required:
        
          - The Customer Engagement (on-premises) user Active Directory account must be a member of the Site Members group on the SharePoint site collection where the documents are stored.
        
          - By default, the claims-based authentication mapping will use the Customer Engagement (on-premises) user’s SharePoint email address and the user’s SharePoint On-Premises work email address for mapping. When this mapping is used, the user’s email addresses must match between the two systems. More information: [Configure user claims mapping using the SharePoint Email Address](#configure-user-claims-mapping-using-the-sharepoint-email-address)

## Other prerequisites and limitations

  - X509 digital certificate to be used for server-based authentication between Dynamics 365 Server and the SharePoint server. The certificate keys must have a minimum of 2048-bit encryption. In most cases this certificate must be issued by a trusted certificate authority, but for evaluation purposes you can use a self-signed certificate.

  - The identity for the CRMAppPool application pool must have read access to the x509 certificate that will be used for server-based authentication with Dynamics 365 Server and the SharePoint server. You can use the Certificates MMC snap-in to grant this access.

  - If you use Microsoft SharePoint 2013, for each SharePoint farm, only one Customer Engagement (on-premises) organization can be configured for server-based integration. However, you can connect more than one Customer Engagement (on-premises) organization to a SharePoint 2016 server farm.

## Prepare Dynamics 365 Server for server-based integration

The CertificateReconfiguration.ps1 is a Windows PowerShell script that installs a certificate to the local certificate store, grants the specified Microsoft Dynamics 365 Asynchronous Processing Service identity access to the certificate, and updates Dynamics 365 Server to use the certificate.

#### Add the server-to-server certificate to the local certificate store and Customer Engagement (on-premises) configuration database

1.  Open a PowerShell command session on all servers where the Dynamics 365 Server Full Server role is installed. 
 
> [!IMPORTANT]
> You must run the command described here on all servers where the Web Application Server role is running.

2.  Change your location to the \<*drive*\>:\\Program Files\\Microsoft Dynamics CRM\\Tools folder.

3.  Run the CertificateReconfiguration.ps1 Windows PowerShell script as explained here:
    
      - **certificateFile** *path\\Personalcertfile.pfx* . Required parameter that specifies the full path to the personal information exchange file (.pfx). More information: Working with digital certificates
    
      - **password** *personal\_certfile\_password*. Required parameter that specifies the private certificate password.
    
      - **certificateType S2STokenIssuer**. Required parameter that specifies the type of certificate. For Customer Engagement (on-premises) and SharePoint server-based integration, only **S2STokenIssuer** is supported.
    
      - **serviceAccount** ‘*DomainName\\UserName*’ or ‘Network Service’.
            
            serviceAccount 'contoso\\CRMWebAppServer' or ‘Network Service’. Required parameter that specifies the identity for the Web Application Server role. The identity is either a domain user account, such as *contoso\\CRMWebAppServer*, or Network Service. The identity will be granted permission to the certificate.
        
      - **updateCrm**. Adds the certificate information to the Microsoft Customer Engagement (on-premises) configuration database.
        

        > [!IMPORTANT]
        > <P>Even if you have multiple Web Application Server or Asynchronous Service roles deployed, you only need to run the command with the updateCrm parameter once.</P>

    
      - *storeFindType FindBySubjectDistinguishedName*. Specifies the type of certificate store. By default, this value is FindBySubjectDistinguishedName and is recommended when you run the script.
    

    > [!IMPORTANT]
    > Although the updateCrm and StoreFindType parameters are optional to run the command, these parameters are required for server-based SharePoint integration so that certificate information is added to the certification database.

    
    Example
    
    ``` powershell
    .\CertificateReconfiguration.ps1 -certificateFile c:\Personalcertfile.pfx -password personal_certfile_password -updateCrm -certificateType S2STokenIssuer -serviceAccount Domain\UserName -storeFindType FindBySubjectDistinguishedName
    ```

## Prepare the SharePoint farm for server-based integration

#### Get the Dynamics 365 Realm ID

1.  Start the Enable Server-Based SharePoint Integration wizard. Go to **Settings** > **Document Management**.

2.  Select **Next**, select **On-Premises**, and then **Next**.

3.  The ID is displayed next to **Dynamics 365 Realm Id** on the page.
    

    > [!TIP]
    > <P>Save the Dynamics 365 Realm ID in a text file on a secure network share or cloud-based storage. Then you can easily retrieve it from the location where you run the Enable Server-Based SharePoint Integration wizard.</P>



On the SharePoint on-premises server, in the SharePoint Management Shell, run these PowerShell commands in the order given.

#### Prepare the SharePoint server for Dynamics 365 Server authentication

1.  If you are using a PowerShell management shell that is not the SharePoint Management Shell, you must register the SharePoint module using the following command.
    
        Add-PSSnapin Microsoft.SharePoint.PowerShell
    
    Enable the PowerShell session to make changes to the security token service for the SharePoint farm.
    
    ``` powershell
    $c = Get-SPSecurityTokenServiceConfig
    $c.AllowMetadataOverHttp = $true
    $c.AllowOAuthOverHttp= $true
    $c.Update()
    ```

2.  Create the trusted security token service object, where *OrganizationName* is the unique name of the Customer Engagement (on-premises) organization and *CrmServer* is the name of the IIS web server where the Customer Engagement (on-premises) web application server role is installed, and -Name “crm” is used to name the security token server (STS).
    

    > [!IMPORTANT]
    > <UL>
    > <LI>
    > <P>Connecting more than one Customer Engagement (on-premises) organization to a single Microsoft SharePoint 2013 server farm is not supported. However, you can connect more than one Customer Engagement (on-premises) organization to a SharePoint 2016 server farm.</P>
    > <LI>
    > <P>When you run the New-SPTrustedSecurityTokenIssuer PowerShell command you must specify HTTPS&nbsp;for&nbsp;the Customer Engagement (on-premises) metadata endpoint when the Customer Engagement (on-premises) web site has only HTTPS or both HTTPS and HTTP bindings, like the following example.</P></LI></UL>

    
    ``` powershell
    New-SPTrustedSecurityTokenIssuer –Name "crm" –IsTrustBroker:$false –MetadataEndpoint https://CrmServer/XrmServices/2015/metadataendpoint.svc/json?orgName=OrganizationName
    ```

3.  Register Customer Engagement (on-premises) with the SharePoint site collection.
    
    To run the following commands, you must specify two parameters:
    
      - The SharePoint On-Premises site collection URL. In the example here, *https://sharepoint.contoso.com/sites/crm/* is used for the site collection URL.
    
      - The *CrmRealmId* is the ID of the Customer Engagement (on-premises) organization you want to use for document management with SharePoint. More information: [Get the Dynamics 365 Realm ID](#get-the-dynamics-365-realm-id)
    

    > [!IMPORTANT]
    > <P>To complete these commands, the SharePoint App Management Service Application Proxy must exist and be running. For more information about how to start and configure the service, see the Configure the Subscription Settings and App Management service applications topic in [Configure an environment for apps for SharePoint](/SharePoint/administration/configure-an-environment-for-apps-for-sharepoint) .</P>

    ```
        $CrmRealmId = "CRMRealmId"
    ```
    ```
        $Identifier  = "00000007-0000-0000-c000-000000000000@" + $CrmRealmId
    ```
    ```
        $site = Get-SPSite "https://sharepoint.contoso.com/sites/crm/"
    ```
    ```
        Register-SPAppPrincipal -site $site.RootWeb -NameIdentifier $Identifier -DisplayName "crm"
    ```

4.  Grant Customer Engagement (on-premises) access to the SharePoint site.
    

    > [!NOTE]
    > <P>In the example below, Customer Engagement (on-premises) is granted permission to the specified SharePoint site collection by using the –Scope sitecollection parameter. The Scope parameter accepts the following options. Use the scope that is most appropriate for your SharePoint configuration:</P>
    > <UL>
    > <LI>
    > <P><EM>site</EM>. Grants Customer Engagement (on-premises) permission to the specified SharePoint website only. It doesn’t grant permission to any subsites under the named site.</P>
    > <LI>
    > <P><EM>sitecollection</EM>. Grants Customer Engagement (on-premises) permission to all websites and subsites within the specified SharePoint site collection.</P>
    > <LI>
    > <P><EM>sitesubscription</EM>. Grants Customer Engagement (on-premises) permission to all websites in the SharePoint farm, including all site collections, websites, and subsites.</P></LI></UL>

    
        $app = Get-SPAppPrincipal -NameIdentifier $Identifier -Site $site.Rootweb
        Set-SPAppPrincipalPermission -AppPrincipal $app -Site $site.Rootweb -Scope "sitecollection" -Right "FullControl" -EnableAppOnlyPolicy
        #"Set up claims-based authentication mapping"
        New-SPClaimTypeMapping -IncomingClaimType "https://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress" -IncomingClaimTypeDisplayName "EmailAddress" -SameAsIncoming

## Run the Enable Server-Based SharePoint Integration wizard

1.  In the Customer Engagement (on-premises), go to **Settings** \> **Document Management**.

2.  In the Document Management area, select **Enable Server-Based SharePoint Integration**.

3.  Review the information and then select **Next**.

4.  For the SharePoint sites, select **On-Premises**, and then select **Next**.

5.  On the **Prepare Sites** stage, enter the following information:
    
      -  SharePoint On-Premises site collection **URL**, such as *https://sharepoint.contoso.com/sites/crm*. The site must be configured for TLS/SSL.
    
      - **SharePoint Realm ID**. Get the SharePoint realm ID

6.  Select **Next**.

7.  The validate sites section appears. If all sites are valid, select **Enable**. If one or more sites are invalid, see Troubleshooting Dynamics 365 Server to SharePoint Server On-Premises server-based integration.

## Select the entities that you want to include in document management

By default, Account, Article, Lead, Product, Quote, and Sales Literature entities are included. You can add or remove the entities that will be used for document management with SharePoint in **Document Management Settings** in for Customer Engagement apps. Go to **Settings** \> **Document Management**. More information: [Enable SharePoint document management for specific entities](../admin/enable-sharepoint-document-management-specific-entities.md) 

## Add OneDrive for Business integration

After you complete Customer Engagement (on-premises) and SharePoint On-Premises server-based integration configuration, you can also integrate OneDrive for Business. With Customer Engagement (on-premises) OneDrive for Business integration, Customer Engagement (on-premises) users can create and manage private documents using OneDrive for Business. Those documents can be accessed within Customer Engagement (on-premises) once the system administrator has enabled OneDrive for Business.

## Enable OneDrive for Business

On the Windows Server where SharePoint Server On-Premises is running, open the SharePoint Management Shell and run the following commands.

    Add-Pssnapin *
    # Access WellKnown App principal
    [Microsoft.SharePoint.Administration.SPWebService]::ContentService.WellKnownAppPrincipals
    
    # Create WellKnown App principal
    $ClientId = "00000007-0000-0000-c000-000000000000"
    $PermissionXml = "<AppPermissionRequests AllowAppOnlyPolicy=""true""><AppPermissionRequest Scope=""https://sharepoint/content/tenant"" Right=""FullControl"" /><AppPermissionRequest Scope=""https://sharepoint/social/tenant"" Right=""Read"" /><AppPermissionRequest Scope=""https://sharepoint/search"" Right=""QueryAsUserIgnoreAppPrincipal"" /></AppPermissionRequests>"
    
    $wellKnownApp= New-Object -TypeName "Microsoft.SharePoint.Administration.SPWellKnownAppPrincipal" -ArgumentList ($ClientId, $PermissionXml)
    
    $wellKnownApp.Update()

## Troubleshooting Customer Engagement (on-premises) to SharePoint Server On-Premises server-based integration

For information about how to troubleshoot the Enable Server-Based SharePoint Integration wizard and view SharePoint monitoring logs, see [Troubleshooting server-based authentication](../admin/troubleshooting-server-based-authentication.md).

## Known issues

For documentation management with SharePoint troubleshooting and known issues, see [Troubleshooting server-based authentication](../admin/troubleshooting-server-based-authentication.md).

## About claims-based authentication mapping

When you use claims-based authentication mapping, the Active Directory domain where the SharePoint server and Dynamics 365 Server are located must be the same. Servers that are located in different Active Directory forests or domains aren’t supported. Similarly, users who are located in external domains to either Dynamics 365 Server or SharePoint Server won’t have access to documents. 

By default, server-based authentication between Customer Engagement (on-premises) and SharePoint on-premises uses the user’s security identifier (SID) to authenticate each user.  If you want to use a custom claims-based authentication mapping, such as the user’s email address, see [Define custom claim mapping for SharePoint server-based integration](../developer/integration-dev/define-custom-claim-mapping-sharepoint-server-based-integration.md) 

### Configure user claims mapping using the SharePoint Email Address
1. Open the form editor to customize the user form. To do this, go to **Settings** > **Security** > **Users**, and then open the user record that you want. 
2. On the toolbar, select **…**, and then select **Form Editor**.

   > [!div class="mx-imgBorder"] 
   > ![Open editor for user form](media/open-form-editor.png "Open editor for user form")

3. Find the **SharePoint Email Address** field in the **Field Explorer** pane and drag and drop it on the **User Information** section of the user form.  

   > [!div class="mx-imgBorder"] 
   > ![Add SharePoint email address field on user form](media/add-sharepoint-email-user-form.png "Add SharePoint email address field on user form")

4. On the form editor toolbar select **Save**, and then select **Publish**. 
5. Close the form editor and refresh the web browser tab to display the newly added field on the user record. 
6. In the user record **SharePoint Email Address** field, enter the user's email address exactly as it appears in SharePoint. 
7. Select **Save**. 
8. Repeat the previous two steps for all users that will need document management. 


## Working with digital certificates

The following procedure creates a personal information exchange file (.pfx).

1.  On a computer that has access to the certificate you want to use for server-to-server authentication, select **Start**, select **Run**, type **MMC**, and then press Enter.

2.  Select **File**, then select **Add/Remove Snap-in**.

3.  In the Available snap-ins list, select **Certificates**, select **Add**, select **Computer account**, select **Next**, select **Finish** to select the local computer, and then select **OK**.

4.  Expand **Certificates**, expand **Personal**, and then select **Certificates**.

5.  Right-click the certificate that you want to use to create a personal certificate file, point to **All Tasks**, and then select **Export**.

6.  Select **Next**, select **Yes** to export the private key, make sure the following options are checked, and then select **Next**.
    
      - Include all certificates in the certification path if possible
    
      - Export all extended properties

7.  Select **Browse** and enter a location and file name for the .pfx file, and then select **Save**.

8.  Select **Next** and then select **Finish**.

## Get the SharePoint realm ID

Run the following PowerShell command in the SharePoint Management Shell, where *https://sharepoint.contoso.com/sites/crm/* is the URL for the SharePoint site collection.

    Get-SPAuthenticationRealm -ServiceContext https://sharepoint.contoso.com/sites/crm/

Alternatively, you can find the SharePoint realm ID in the site app permissions setting of the SharePoint site collection.

1.  Sign in to the SharePoint site collection that you will use for document management with Customer Engagement (on-premises).

2.  Go to **Site settings** \> **Site app permissions**.

3.  The realm ID is displayed under **App Identifier** to the right of the @ sign. Copy it to the clipboard. In the Enable Server-Based SharePoint Integration wizard, paste in only the GUID. Do not paste in any part of the identifier to the left of @.




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]