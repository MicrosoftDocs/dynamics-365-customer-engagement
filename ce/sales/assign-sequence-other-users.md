---
title: "Assign a sequence to other user or team"
description: "Assign your sequences to a user or a team to use them in sales accelerator."
ms.date: 09/30/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Assign a sequence to a user or a team

Provide permissions for a user or a team to access your sequence in sales accelerator.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Assign a sequence

Sequences that you create are available only for you. However, you can assign the sequences that you've created to a user or team. By assigning the sequences, you provide full permissions (read, edit, and delete) to the sequence.

1. Sign in to the **Sales Hub** app, and in the lower-left corner of the page, go to **Change area** > **Sales Insights settings**.   

1. Under **Sales accelerator**, select **Sequence**.     

1. Select the sequence that you want to assign to a user or a team, and select **Assign**.

    :::image type="content" source="media/sequence-assign-select-sequence.png" alt-text="Select a sequence to assign to a user and a team.":::

1. On the **Assign sequence** dialog box, Enter the following information:

    | Parameter | Description |
    |-----------|-------------|
    | Assign to | Select the **User or team** option to choose a user or a team to access the sequence. The **User or team** parameter will be disabled, if you choose the **Me** option. |
    | User or team | From the lookup, select the user or team for who you want to assign the sequence. You can assign the sequence to only a user or a team. To assign to multiple users, create a team with the required users and then assign the sequence to that team.  | 

    :::image type="content" source="media/sequence-assign-assign-sequence.png" alt-text="Assign sequence dialog box.":::

1. Select **Assign**.

The sequence is assigned to the selected user or team.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate a sequence](create-and-activate-a-sequence.md)
