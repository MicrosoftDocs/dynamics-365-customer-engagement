---
title: "Troubleshooting LinkedIn integration errors (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with LinkedIn integrations in Dynamics 365 Sales."
ms.date: 05/22/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting LinkedIn integration errors

This article helps you troubleshoot and resolve issues related to LinkedIn integrations in Dynamics 365 Sales.

## Error in enabling LinkedIn updates

When enabling the data validation option in the **Sales Navigator Integration Settings** dialog box, you might see the status that data validation has failed. The possible errors are:  
- Data validation has failed because CRM sync is disabled in LinkendIn Sales Navigator.
- Data validation failed with some other error (for example, unexpected error).

![Error in enabling LinkedIn updates](media/lisn-update-error.png "Error in enabling LinkedIn updates")

More information on data validation capability of LinkedIn Sales Navigator: [Data validation](https://docs.microsoft.com/dynamics365/linkedin/data-validation)

**Resolution**

- If you get the data validation failure due to CRM sync being disabled, verify the following:
    - CRM sync is enabled on LinkedIn Sales Navigator.
    - The setting for data validation is enabled in LinkedIn Sales Navigator. If this setting isn't turned on, you'll see the CRM sync disabled status even though CRM sync is enabled. If you are not able to see the data validation setting in LinkedIn Sales Navigator, ensure that you have an appropriate Sales Navigator license. More information: [Sales Navigator Data Validation - Overview](https://www.linkedin.com/help/sales-navigator/answer/a120992)
    - If both the above settings are enabled, ensure that you have, at least once, turned on the data validation setting on CRM, after both the above settings are turned on.
- If the error is something other that CRM sync, you can try restarting data validation by first disabling it from the **Sales Navigator Integration Settings** dialog box and then by enabling it again.

### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)
