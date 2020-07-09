---
title: "Troubleshooting LinkedIn integration errors (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with LinkedIn integrations in Dynamics 365 Sales."
ms.date: 05/26/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Troubleshooting LinkedIn integration errors

This article helps you troubleshoot and resolve issues related to LinkedIn integrations in Dynamics 365 Sales.

## Error in enabling LinkedIn updates

When enabling the data validation option (**Enable LinkedIn updates**) in the **Sales Navigator Integration Settings** dialog box, you might see the status that data validation has failed. The possible errors are:  

- Data validation has failed because CRM sync is disabled in LinkedIn Sales Navigator.
- Data validation failed with some other error (for example, an "unexpected error").

![Error in enabling LinkedIn updates](media/lisn-update-error.png "Error in enabling LinkedIn updates")

For more information about the data validation capability of LinkedIn Sales Navigator, see [Data validation](https://docs.microsoft.com/dynamics365/linkedin/data-validation).

**Resolution**

- If you get the data validation failure because CRM sync was disabled, verify the following:

  - CRM sync is enabled in LinkedIn Sales Navigator.

  - The setting for data validation is enabled in LinkedIn Sales Navigator. If this setting isn't turned on, you'll see the CRM sync disabled status even though CRM sync is enabled. If you aren't able to see the data validation setting in LinkedIn Sales Navigator, ensure that you have an appropriate Sales Navigator license. More information: [Sales Navigator Data Validation - Overview](https://www.linkedin.com/help/sales-navigator/answer/a120992)

  - If you've turned on both the settings, ensure that you've turned on the **Enable LinkedIn updates** setting at least once.

- If the error is due to something other than CRM sync, you can try restarting data validation by first disabling it from the **Sales Navigator Integration Settings** dialog box, and then enabling it again.

### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)
