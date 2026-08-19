1. Like other users, the agent user needs a license to access Dynamics 365 Sales. In Microsoft 365 admin center, add the appropriate Sales license to the agent user. [Learn more about assigning licenses for users in Microsoft 365 admin center](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide&preserve-view=true).
    1. In the [Microsoft 365 admin center](https://admin.microsoft.com/), search for the agent name in the search bar at the top of the page, and select the agent user from the search results.
    1. In the right pane, select **Licenses and Apps**.
    1. Assign the appropriate Sales license to the agent user.
    1. Select **Save changes**.
1. In Power Platform admin center, add the agent user to your Dynamics 365 Sales instance and assign the appropriate role. The Sales Development Agent is configured to use the **Salesperson** role, but you can also use a custom role with permissions to access and manage leads. Learn more about [assigning a security role to a user in Power Platform admin center](/power-platform/admin/assign-security-roles).
    1. In the [Power Platform admin center](https://admin.powerplatform.microsoft.com/), select **Manage** in the left navigation pane.
    1. Select **Environments**, and then select your Dynamics 365 Sales environment.
    1. Select **Settings** > **Users + permissions** > **Agents (preview)**.
    1. Select **Add agent**.
    1. Enter the agent name in the search bar, select the agent user from the search results, and then select **Add**.
    1. Select the Salesperson role (or a custom role with appropriate permissions) for the agent user, and then select **Save**.
    1. Select **Save** to confirm the role assignment.

