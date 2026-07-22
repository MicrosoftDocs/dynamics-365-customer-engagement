---
title: Get help with Field Service
description: Find solutions to common issues, troubleshoot errors, and learn how to contact support for Dynamics 365 Field Service.
ms.date: 04/08/2026
ms.topic: how-to
author: jshotts
ms.author: jasonshotts
---

# Get help with Field Service

Use this page to find solutions to common issues with Dynamics 365 Field Service and Resource Scheduling. If you can't resolve the issue, [contact support](#contact-support) at the bottom of this page.

> [!TIP]
> **Administrators:** [Run Solution Health Hub](troubleshoot-field-service-solution-health.md) to automatically diagnose common configuration and setup issues in your environment.

## Start here: find your issue

Select the category that best matches your issue to find relevant troubleshooting articles.

### Schedule board issues

- [Schedule board shows a blank page or fails to load](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-not-loading)
- [Schedule board is slow or experiences high latency](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-performance)
- [Resources don't display on the schedule board](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-missing-resources)
- [Booking card shows NaN or incorrect date and time](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-nan-datetime)
- [Issue with cascading crew changes when assigning a booking](/troubleshoot/dynamics-365/field-service/scheduling/cascade-crew-changes-booking)
- [Learn how to use the schedule board](work-with-schedule-board.md)

### Work order and agreement issues

- [Agreement booking setup doesn't create work orders](/troubleshoot/dynamics-365/field-service/work-order/agreement-work-orders-not-generated)
- [Work order doesn't save or create successfully](/troubleshoot/dynamics-365/field-service/work-order/work-order-creation-errors)
- [Work order status doesn't change as expected](/troubleshoot/dynamics-365/field-service/work-order/work-order-status-stuck)
- [Learn about the work order life cycle](work-order-status-booking-status.md)

### Mobile app issues

- [Troubleshoot common issues with the Field Service mobile app](/troubleshoot/dynamics-365/field-service/mobile-app/mobile-app-common-issues)
- [Incorrect or missing data in offline mode](/troubleshoot/dynamics-365/field-service/mobile-app/incorrect-missing-data-offline-mode)
- [Booking timestamp is created with an incorrect time](/troubleshoot/dynamics-365/field-service/mobile-app/booking-timestamp-incorrect-time)
- [Error on startup due to missing files in the solution](/troubleshoot/dynamics-365/field-service/mobile-app/newux-error-on-start-missing-files)
- [Error on startup due to permission or privilege issues](/troubleshoot/dynamics-365/field-service/mobile-app/newux-error-on-start-permission)

### Installation and update issues

- [Install or upgrade Field Service](install-field-service.md)
- [Uninstall Dynamics 365 Field Service](uninstall-field-service.md)
- [Troubleshoot issues with Field Service solution health](troubleshoot-field-service-solution-health.md)
- [Version history](version-history.md) - check if a recent update relates to your issue

### Permissions and role issues

- ["The user hasn't been assigned any roles" error](/troubleshoot/dynamics-365/field-service/administration/user-has-no-roles)
- [Can't find a user when setting up frontline workers](/troubleshoot/dynamics-365/field-service/administration/cannot-find-user-set-up-frontline-workers)
- [Set up users and security roles](users-licenses-permissions.md)

### Resource Scheduling Optimization (RSO) issues

- [Requirements not scheduled](/troubleshoot/dynamics-365/field-service/rso/requirement-not-scheduled-in-rso)
- [Optimization request fails to modify some bookings](/troubleshoot/dynamics-365/field-service/rso/system-failed-modify-bookings-error)
- [Troubleshoot issues with RSO deployments](/troubleshoot/dynamics-365/field-service/rso/troubleshoot-rso-deployment)
- ["SAS Key has not been configured" error](/troubleshoot/dynamics-365/field-service/rso/sas-key-not-configured-error)

### IoT and Connected Field Service issues

- [No records after pulling IoT device data](/troubleshoot/dynamics-365/field-service/iot/no-device-history-properties)
- [Troubleshoot issues with IoT capabilities](/troubleshoot/dynamics-365/field-service/iot/troubleshoot-iot-issues-logic-app)

## Common error messages

If you see a specific error message, find it in this list for quick guidance.

| Error message | Likely cause | Next step |
|---|---|---|
| "Field Service is currently not available in your account" | The user doesn't have a Field Service license assigned, or the app isn't installed in the environment. | Verify [license assignment and app installation](install-field-service.md). |
| "Web resource method does not exist: FS.Contact.Library.Load" | A solution update caused a version mismatch in web resources. | [Run Solution Health Hub](troubleshoot-field-service-solution-health.md) and check for solution version conflicts. |
| "Combined execution time of incoming requests exceeded limit of 1,200,000 milliseconds" | The environment is experiencing high load or has long-running custom plugins. | Reduce concurrent requests and review [custom plugin performance](/power-apps/developer/data-platform/best-practices/business-logic/optimize-assembly-development). |
| "The plug-in execution failed because no Sandbox Hosts are currently available" | The Dataverse sandbox service is temporarily unavailable. | Wait and retry. If persistent, check environment health in the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). |
| "Installing Field Service on a CDS instance isn't supported" | Attempting to install Field Service on an unsupported environment type. | Ensure the environment has a Dataverse database. See [installation prerequisites](install-field-service.md). |

## Before you contact support

Try these steps to resolve or narrow down the issue:

1. **Check for known issues.** Review the [version history](version-history.md) to see if a recent update introduced a known issue or behavior change.
1. **Run Solution Health Hub.** Administrators can [run diagnostic tests](troubleshoot-field-service-solution-health.md) that automatically detect common configuration problems.
1. **Clear browser cache.** Many schedule board and form loading issues are resolved by clearing the browser cache and cookies, then performing a hard refresh (Ctrl+Shift+Delete, then Ctrl+F5).
1. **Test in a private browser window.** Open an InPrivate or incognito window to rule out browser extension conflicts.
1. **Check user permissions.** Verify the affected user has the correct [security roles](users-licenses-permissions.md) (for example, Field Service - Administrator or Field Service - Dispatcher).
1. **Review system jobs.** For issues with automated processes (agreements, workflows), select **Settings** (gear icon) on the navigation bar > **Advanced Settings** > **System** > **System Jobs** to check for failed jobs.

## Related content

- [Browse all Field Service troubleshooting articles](/troubleshoot/dynamics-365/field-service/welcome-field-service)
- [Field Service documentation](overview.md)
- [Dynamics 365 Field Service community forum](https://community.dynamics.com/forums/thread/?partialUrl=fieldservice)
- [Dynamics 365 ideas portal](https://experience.dynamics.com/ideas/categories/?forum=bee3d862-df65-e811-a95d-000d3a1be7ad&forumName=Dynamics%20365%20Field%20Service)

## Contact support

If you can't resolve the issue by using the resources in the preceding section, administrators can [create a support request](/power-platform/admin/get-help-support) through the Power Platform admin center.

When you create a request, include the following information to speed up resolution:

- The exact error message or error code
- Steps to reproduce the issue
- The environment URL and type (production, sandbox, or trial)
- Whether the issue started after a recent update

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
