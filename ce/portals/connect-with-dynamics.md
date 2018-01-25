---
title: "Connect a portal with Dynamics 365 online organization | MicrosoftDocs"
description: "Learn about how a portal is connected with Dynamics 365 online organization and how to renew the authentication key."
keywords: "portal authentication key, connect with Dynamics 365"
ms.date: 01/25/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 962C5655-3F9D-4D1D-8D13-DB9B1058CABF
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Connect with Dynamics 365 online organization

A portal connects to Dynamics 365 online organization as an application by using an Azure Active Directory application. The application is created in the same tenant where the portal is available after its provisioning. The application is registered with the Dynamics 365 organization during the portal provisioning process.

![Connecting a portal with Dynamics 365 organization](media/connect-with-dynamics.png "Connecting a portal with Dynamics 365 organization")

Each portal has a separate Azure Active Directory application associated to it irrespective of whether they are connected to same Dynamics 365 organization or not. The default Azure Active Directory authentication provider created for a portal uses the same Azure Active Directory application to integrate Azure Active Directory authentication with the portal. Authorization is enforced by using web roles associated with the user accessing the portal.

You can see the application associated with a portal in Azure Active Directory. The name of this application will be Microsoft CRM Portals. The portal ID will also be available in the **App ID URI** field. The owner of this application would be the user who has provisioned the portal. You should not delete or modify this application, as this can break the portal functionality. You must be an owner of the application to manage a portal from Portal Admin Center.

## Authentication key

For a Portal to connect to Dynamics 365 using Azure Active Directory application, it requires an authentication key connected to the Azure Active Directory application. This key is generated when you provision a portal and the public part of this key is uploaded to Azure Active Directory application automatically.

> [!IMPORTANT]
> The authentication key once created has an expiration of two years. It must be renewed every two years to ensure that your portal is able to connect to the Dynamics 365 organization. If you do not update the key on time, the portal will stop functioning.  

You can see the details of the authentication key on the following screens:

**Portal Admin Center**

1. Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2. Select the name of the portal you want to see the key, and then select **Manage**.
3. Select **Manage portal authentication key**. The existing authentication key is displayed along with its expiration date and thumbprint.

  ![Authentication key details in Portal Admin Center](media/manage-auth-key.png "Authentication key details in Portal Admin Center")

**Portal**

1.	Sign in to portal as administrator.
2.	Navigate to the URL <portal_path>/_services/about. The expiration date of the existing authentication key is displayed. 

  ![Portal service page](media/portal-services-page.png "Portal service page")

> [!NOTE]
> To view this information, you  must be signed in to your portal in the same browser session with a user that has all website access permission assigned.

To ensure that you are aware of the authentication key expiration, the notification is shared through the following mechanisms:

**Email**

Emails will be sent to all the users who have signed up for Email notifications for the organizations connected to their portal. More information about signing up for email notification: [Manage email notifications to admins](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/manage-email-notifications)

Email notifications are sent at the following intervals: 
- 90 days 
- 60 days 
- 30 days 
- 15 days 
- 7 days 
- 6 days 
- 5 days 
- 4 days 
- 3 days 
- 2 days 
- 1 day 
- 12 hrs 
- 6 hrs 
- 3 hrs 
After expiry (once every day till 1 week after key expires)

> [!NOTE]
> - Intervals are calculated in UTC from the key expiry date.
> - Emails are not guaranteed exactly on the same interval as listed above and can be delayed sometimes as well as some intervals can be missed. Ensure that you check for the key expiration date through the screens as well.

**Portal Admin Center**

A message about key expiration is displayed at the top of the page.

![Authentication key notification in Portal Admin Center](media/portal-admin-center-auth-notif.png "Authentication key notification in Portal Admin Center")



