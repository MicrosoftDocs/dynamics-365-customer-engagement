---
title: Manage the Service app in the Microsoft 365 admin center
description: Learn how to install or remove the Service app and manage its deployment and availability for users and groups.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 09/30/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Manage the Service app in the Microsoft 365 admin center

Use the Microsoft 365 admin center to manage the Service app for your organization. The Service app packages Service Agent and Customer Service plugins for supported Copilot experiences. Check availability for each experience separately. The Service app installation doesn't confirm that Chat or Cowork is enabled or available to every assigned user.

Manage deployment at the app level. The package doesn't provide separate administrator targeting for individual Service components. If you remove Service, it can affect more than one experience.

## Understand access controls

| Control | What it governs | What it doesn't grant |
|---|---|---|
| Microsoft 365 administrator roles | Privileges to install or manage apps and agents, or assign roles, as permitted by the specific role. | User access to Customer Service records. |
| Service app assignment and Microsoft Entra groups | Determines who receives the app and who is allowed to install or use it. Deployment and availability scopes are independent. | A Microsoft 365 administrator role, host entitlement, or Dynamics 365 data rights. |
| Dynamics 365 security roles and data access | Environments, tools, records, and actions a user can access. | Access to a Copilot host or authority to administer the Service app. |
| Host access, licensing, and billing | Whether the user can use Cowork under the applicable organizational policies and commercial requirements. | App assignment or broader Dynamics 365 permissions. |

## Prerequisites and administrator responsibilities

To install the Service app from Microsoft Marketplace, you need permissions equivalent to the tenant administrator and a paid license for using its capabilities.

Use the least-privileged verified role for each administrative task. The account that assigns administrator roles must also have permission to assign those roles, such as an appropriate privileged role administrator.

Before you deploy Service:

- Plan the intended user or group cohort.
- Confirm applicable licenses and host policies.
- Coordinate Customer Service MCP configuration and data access with the Dynamics 365 administrator.

The addition of Microsoft Copilot to a Customer Service environment is a separate, in-app Service Agent configuration task.

## Assign administrator roles

1. Sign in to the [Microsoft 365 admin center](https://admin.microsoft.com/) with an account authorized to assign the intended administrator role.
1. Complete the steps in [Assign admin roles in the Microsoft 365 admin center](/microsoft-365/admin/add-users/assign-admin-roles).
1. Verify the assignment and limit its duration or remove elevated access when it is no longer needed under your organization's policy.

Role assignment changes administrative authority. Assign Service app access and Dynamics 365 security roles separately. Don't grant administrator roles to users to make the plugin appear.

## Install the Service app

1. In the Microsoft 365 admin center, go to **Agents** > **All agents** > **Registry**. Locate **Service**, and inspect its status and existing assignments. The app might already be installed.
1. If Service isn't installed, open [Service in Microsoft Marketplace](https://marketplace.microsoft.com/product/WA200006602). If you search Marketplace, confirm that the app name is **Service** and the publisher is **Microsoft Corporation**.
1. Select **Get it now**, and complete the installation wizard by using the administrator account required by the Service app.
1. Review the requested permissions, terms, and intended deployment scope before you confirm. The default scope might not match a limited rollout.
1. Return to the Service entry in the admin center and verify its installation status.
1. Review both **Installed to** or **Installed for** and **Available to** on the **Users** tab. Test with an intended user only after host access and Dynamics 365 permissions are also in place.

## Deploy to users or groups and manage availability

**Installed to** or **Installed for** identifies preinstallation targets. **Available to** controls who can install or use the app. These scopes are independent. Preinstallation can include users outside the availability scope, and organization-wide installation can override a limited scope.

1. Open the Service app details in **Agents** > **All agents** > **Registry**, and then select **Users**.
1. Review existing installations and effective Microsoft Entra group membership.
1. For preinstallation, edit **Installed to** and select **Just me**, **Entire organization**, or **Specific users or groups**, as appropriate.
1. Edit **Available to**. Select **No users in the organization can install**, **All users**, or **Specific users or groups**, as appropriate.
1. For a restricted rollout, align both scopes with the intended cohort, and then select **Update**.
1. Verify the saved settings and test effective access with intended and excluded users.

If access is unexpected, inspect overlapping groups and previous or organization-wide installations. Changing only **Available to** isn't sufficient to narrow a broader deployment.

## Restrict access or block the app

To remove selected users from a rollout, remove them from deployment and availability cohorts as applicable. Check effective membership in every included group, review existing installations, save the settings, and verify access. Manage host access and Dynamics 365 permissions separately.

To prevent organization-wide use, open the Service app details, select **Block**, and then review and confirm the action. Blocking prevents installation and use and removes the app from users who already installed it. Verify the result in each affected experience.

## Uninstall the Service app

1. Review affected users and notify service owners before you remove Service. The action targets the shared app package, not only one host or skill.
1. In **Agents** > **All agents** > **Registry**, select **Service**, select **Uninstall**, and then review and confirm the removal.
1. Verify the app status and effective user access after removal. Check each affected host with representative users.

Use **Block** as a separate policy control when you also need to prevent installation and use. Uninstalling Service doesn't delete Dynamics 365 records, remove host licenses, or reverse actions that already completed.

## Review host access, permissions, and costs

App installation and assignment don't enable a host or substitute for its licensing and billing configuration. Manage Cowork access through the applicable organizational spending policy. Dynamics 365 security roles continue to determine service-data access. Test with the user's regular account instead of an administrator account.

Review destination-service terms and your organization's data policies before you allow service information to be processed by another experience. External services can incur costs, and data can leave the Dynamics 365 compliance or geographic boundary.

## Troubleshoot common issues

If installation or consent fails, verify the Service-specific Marketplace role requirement and the administrator's active permissions. A read-only role isn't sufficient. If role assignment fails, verify the acting account's authority to assign roles.

If Service is installed but unavailable to a user, check both scopes on the **Users** tab, overlapping group memberships, host access, and release availability. If the host, such as Cowork, opens but records or tools are missing, check the account, environment, mapped Dynamics 365 privileges, and required MCP configuration instead of assigning a Microsoft 365 administrator role.

If an excluded user still has access, review previous installations and organization-wide assignments as well as **Available to**, and confirm that the change has taken effect in the affected experience.

## Related information

[Use Customer Service skills in Copilot Cowork](use-copilot-cowork-service-skills.md)  
[Assign administrator roles in the Microsoft 365 admin center](/microsoft-365/admin/add-users/assign-admin-roles)  
[Manage agents in the Microsoft 365 admin center](/microsoft-365/admin/manage/agent-details)  
[Administrator roles and permissions for agents](/microsoft-365/admin/manage/agent-roles-perms)  
[Enable Service Agent in Microsoft 365 Copilot](../administer/configure-service-agent.md)  
