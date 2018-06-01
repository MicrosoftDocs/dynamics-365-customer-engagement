---
title: "Reset a Dynamics 365 portal | MicrosoftDocs"
description: "Learn how to reset a portal."
ms.date: 05/31/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 02FA490A-92DB-461C-B1CA-7B93D037F5D6
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---
<!--Note to author: Changed the title below to match the title in the metadata.-->

# Reset a Dynamics 365 portal

<!--Note to author: please review the revisions in the following paragraph for accuracy.-->
Once a portal is provisioned, you might need to delete resources from your portal under certain circumstances, such as if you move your Dynamics 365 organization to another tenant or another datacenter or if you want to remove the portal from your organization.

To do this, you can reset your portal, which will delete all the hosted resources associated with it. Then you can provision the portal again. Once the reset operation is finished, your portal URL will not be accessible anymore.

It is important to note that resetting your portal doesn’t remove portal configuration or solutions present in your Dynamics 365 instance and they will remain as is.

You can reset a completely configured portal, or a portal for which provisioning or updating of a Dynamics 365 instance has failed.

To reset a configured portal:
<!--Note to author: Step 1 says "Applications" (plural) tab, but farther down it says "Application" (singular) tab. Which is correct?-->

1.	Go to the Dynamics 365 Administration Center page and select the **Applications** tab.

2.	Select the name of the portal that you want to reset, and then select **Manage**.

3.	Go to **Portal Actions** > **Reset Portal**.

    ![Reset a portal](media/reset-portal.png "Reset a portal")

4.	Select **Reset** in the confirmation window.

<!--Note to author: Should the above say Reset Portal to match the screenshot?-->

> [!NOTE]
> - If you don't have appropriate permissions on an associated Azure Active Directory application, an error is displayed. You must contact the global administrator for the appropriate permissions.
> - When the portal is reset successfully, the portal name and its status on the **Application** tab in the Dynamics 365 Administration Center does not change. For example, if your portal name and status were Portal 1 and Configured respectively, then after resetting the portal, these values do not change. If you want to change the portal name, you can change it on the **Portal Details** tab in the Portal Admin Center. However, the status value cannot be reverted to Not Configured.

<!--Note to author: Is the Portal Admin Center the same as the Dynamics 365 Administration Center? If yes, I recommend being consistent in how we refer to it.-->

  > It is important to note that the portal's status on the **Application** tab does not represent its provisioning status and does not affect the functioning of your portal. It just shows whether you have ever accessed the Portal Admin Center for that corresponding portal or not.

If your portal is not provisioned correctly, it goes into an error state and the following screen is displayed. In this case, you can also reset the portal by selecting **Reset Portal** on the error screen.

![Error while provisioning a portal](media/provision-portal-error.png "Error while provisioning a portal")

## Troubleshooting

This section provides information about troubleshooting issues while resetting a portal.

### Reset request could not be submitted

If a portal reset request could not be submitted, an error is displayed as shown in the following image. In this case, you must close and reopen the Portal Admin Center, and try to reset the portal again. If the issue persists, contact Microsoft support.

![Error while resetting a portal](media/reset-portal-request-error.png "Error while resetting a portal")

### Reset portal job fails

If a reset portal job fails, an error message is displayed along with the **Reset Portal** action.

![Error while resetting a portal](media/reset-portal-error.png "Error while resetting a portal")

Typically, these are transient errors and you must select **Reset Portal** to restart the job. If the issue persists, contact Microsoft support.

