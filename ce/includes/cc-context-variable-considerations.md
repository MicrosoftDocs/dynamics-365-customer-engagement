We recommend that you don't update or delete the context variables after you create them. If you do need to update or delete the variables, make sure that they aren't used in any of the unified routing classification or assignment rules.

When you configure context variables for Azure or Power Virtual Agents bots, check for the following conditions:

- Use the context variable names as defined and don't change them when you author flows in Azure or Power Virtual Agents bots.
- The length of the context variable name must be less than or equal to 200 characters.
- The context variable value must be less than or equal to 4,000 characters.
- Use exact match to pass the value to the context variable because it is case-sensitive.