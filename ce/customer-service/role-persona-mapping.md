---
title: "Role persona mapping | MicrosoftDocs"
description: "Information about how security roles can be mapped to personas."
ms.date: 06/03/2021
ms.topic: article
author: meghanalanka
ms.author: v-mlanka
manager: shujoshi
---

# Add custom security roles in Customer Service

As part of unified routing you can enable the persona mapping settings. Persona mapping gives your organization the option to add custom security roles alongside existing Customer Service and Omnichannel for Customer Service roles. The admin, supervisor, and agent personas are user archetypes that security roles can map to. By mapping custom security roles to personas, you can fine-tune data access and security across users and business units.

You can create and assign custom security roles in the Microsoft Dynamics 365 admin center. Persona mapping can be found in the Omnichannel admin center or Customer Service Hub in the **User attributes** section. For the custom security roles to be functional, perform the following steps.

1. Create custom security roles.
2. Map roles to personas.
3. Enable access to applications.
4. Enable access to forms and dashboards.

## Create custom security roles

Custom security roles can be created at an organizational or business unit level, and you can edit access level for records and tasks. Addition of custom security roles is optional. To ensure persona mapping works, perform the following steps:

1. Identify what tasks a user will need to perform.
2. [Create a copy of an existing role](/power-platform/admin/create-edit-security-role#create-a-security-role-by-copy-role) as your starting point.

   Custom security roles must have correct minimum access levels for the appropriate records to ensure feature functionality. You can copy one of the following predefined security roles:

   - Omnichannel admin
   - Omnichannel supervisor
   - Omnichannel agent
   - CSR Manager
   - Customer Service Representative

3. Customize permissions and access levels for your new security role.
4. Save the security role with a name that will help you identify it during persona mapping.

For example, if your organization is expecting a large seasonal increase in chat service requests, you might hire some seasonal employees to exclusively handle chat channels. You could create a security role for the "seasonal service rep" using the steps above. First, you'd identify that users with this role are part of the agent archetype. Knowing that, you would create a copy of the "Omnichannel  agent" security role. By starting with a copied role, you are less likely to face user issues by under-granting privilege. As part of customizing, you might remove read access for records not related to chat, such as Survey feedback, SMS, or voice channels. Finally, you can save the new security role as "seasonal service rep".

## Map roles to personas

After it is enabled, persona mapping will automatically assign default roles depending on the Dynamics 365 services enabled for your environment. For an environment with Customer Service Enterprise license, the default mapping includes Customer Service Representative and CSR manager roles. For an environment with Omnichannel for Customer Service, the three primary security roles are mapped to personas. If both services are enabled, both sets of default mappings are included. The following table contains the mapping information for the roles in Customer Service and Omnichannel for Customer Service.

| Service | Admin persona default mapping | Supervisor persona default mapping | Agent persona default mapping |
| ------------- | ---------------- | ------------------- | --------------- |
| Customer Service Enterprise | CSR Manager | CSR Manager | Customer Service Representative |
| Omnichannel for Customer Service | Omnichannel administrator | Omnichannel supervisor | Omnichannel agent |  
| Customer Service Enterprise + Omnichannel for Customer Service | CSR Manager + Omnichannel administrator | CSR Manager + Omnichannel supervisor | Customer Service Representative + Omnichannel agent |
|||||

> [!NOTE]
> Customized mappings will not be reset if one of these services is added later.

### Manage personas

To customize the role to persona mapping, perform the following steps.

1. In Customer Service Hub, go to the **Service Management** change area, and select **User attributes** from the **Unified routing** menu. If you're using Omnichannel admin center, select **User attributes** under **Advanced settings**.

2. Select **Manage** for **Role persona mapping**.

3. Select any one of the personas to add or remove security roles.

4. Select or clear the selection from the checkboxes next to the security roles in the configuration window.

5. Select **Save and Close**.

The updated configuration will now appear next to each persona.

Continuing the example, you will select the **Agent** persona. Within the configuration window, locate the new "seasonal service rep" security role and select the checkbox. After you select **Save and Close**, the custom security role will be listed under the agent persona. With role to persona mapping completed you would want to grant access to any applications and forms they would use.

## Enable access to applications

Users with security roles mapped to personas do not get automatic access to associated dashboards or applications. Access needs to be provided by administrators.

Perform the following steps to ensure that access and privileges are provided to users.

1. Create the required user role. More information: [Create users and assign security roles](/power-platform/admin/create-users-assign-online-security-roles).

2. Add and edit user permissions and privileges as required.

3. Sign in to Dynamics 365.

4. Select the ellipsis in the application tile.

5. Select **Manage roles**.

6. In the dialog box that appears, select the custom role that you want to grant permission to and select **Save**.

## Enable access to forms and dashboards

To enable access to a form or dashboard, perform the following steps:

1. Sign in to Dynamics 365.

2. Go to **Advanced Settings** > **Settings**.

3. Select **Customizations** > **Customize the system**.

4. From the **Solution Default Solution** list, select **Entities** > **Characteristics**, and then **Forms**.

5. Open an active form, and select **Enable security roles**.

6. Select the role that you want to provide access to, and select **OK**.


### See also

[Overview of unified routing](overview-unified-routing.md)  
[Manage users for unified routing](users-user-profiles.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]  
