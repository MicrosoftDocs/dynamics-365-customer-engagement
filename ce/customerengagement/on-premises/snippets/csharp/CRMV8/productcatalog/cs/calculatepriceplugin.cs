// <snippetcalculatepriceplugin>


using System;
using System.ServiceModel;

// Microsoft Dynamics CRM namespace(s)
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    public class CalculatePricePlugin : IPlugin
    {
        /// <summary>
        /// A plugin that calculates custom pricing for 
        /// opportunities, quotes, orders, and invoices.
        /// </summary>
        /// <remarks>Register this plug-in on the CalculatePrice message,
        /// Post Operation execution stage, and Synchronous execution mode.
        /// </remarks>
        public void Execute(IServiceProvider serviceProvider)
        {
            //Extract the tracing service for use in debugging sandboxed plug-ins.
            ITracingService tracingService =
                (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            
            // Obtain the execution context from the service provider.
            IPluginExecutionContext context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));
            
            if (context.ParentContext != null
                && context.ParentContext.ParentContext != null
                && context.ParentContext.ParentContext != null
                && context.ParentContext.ParentContext.ParentContext.SharedVariables.ContainsKey("CustomPrice")
                && (bool)context.ParentContext.ParentContext.ParentContext.SharedVariables["CustomPrice"])
                return;
            
            // The InputParameters collection contains all the data passed in the message request.            
            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is EntityReference)
            {
                // Obtain the target entity from the input parmameters.
                EntityReference entity = (EntityReference)context.InputParameters["Target"];                

                // Verify that the target entity represents an appropriate entity.                
                if (CheckIfNotValidEntity(entity))
                    return;

                try
                {
                    context.SharedVariables.Add("CustomPrice", true);
                    context.ParentContext.SharedVariables.Add("CustomPrice", true);
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    // Calculate pricing depending on the target entity
                    switch (entity.LogicalName)
                    {
                        case "opportunity":
                            CalculateOpportunity(entity, service);
                            return;

                        case "quote":
                            CalculateQuote(entity, service);
                            return;

                        case "salesorder":
                            CalculateOrder(entity, service);
                            return;

                        case "invoice":
                            CalculateInvoice(entity, service);
                            return;

                        case "opportunityproduct":
                            CalculateOpportunityProduct(entity, service);
                            return;

                        case "quotedetail":
                            CalculateQuoteProduct(entity, service);
                            return;

                        case "salesorderdetail":
                            CalculateOrderProduct(entity, service);
                            return;

                        case "invoicedetail":
                            CalculateInvoiceProduct(entity, service);
                            return;

                        default:
                            return;
                    }                   
                }
                
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("CalculatePrice: {0}", ex.ToString());
                    throw new InvalidPluginExecutionException("An error occurred in the Calculate Price plug-in.", ex);
                }                

                catch (Exception ex)
                {
                    tracingService.Trace("CalculatePrice: {0}", ex.ToString());
                    throw;
                }
            }
        }

        private static bool CheckIfNotValidEntity(EntityReference entity)
        {
            switch (entity.LogicalName)
            {
				case "opportunity":
                case "quote":
				case "salesorder":				
				case "invoice":
				case "opportunityproduct":
				case "invoicedetail":
				case "quotedetail":
				case "salesorderdetail":
					return false;

				default:
                    return true;
            }
        }

        #region Calculate Opportunity Price
        // Method to calculate price in an opportunity        
        private static void CalculateOpportunity(EntityReference entity, IOrganizationService service)
        {
            Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("statecode"));
            OptionSetValue statecode = (OptionSetValue)e["statecode"];
            if (statecode.Value == 0)
            {
                ColumnSet columns = new ColumnSet();
                columns.AddColumns("totaltax", "totallineitemamount", "totalamountlessfreight", "discountamount");
                Entity opp = service.Retrieve(entity.LogicalName, entity.Id, columns);

                QueryExpression query = new QueryExpression("opportunityproduct");
                query.ColumnSet.AddColumns("quantity", "priceperunit");
                query.Criteria.AddCondition("opportunityid", ConditionOperator.Equal, entity.Id);
                EntityCollection ec = service.RetrieveMultiple(query);
                opp["totallineitemamount"] = 0;

                decimal total = 0;
                decimal discount = 0;
                decimal tax = 0;                

                for (int i = 0; i < ec.Entities.Count; i++)
                {
                    total = total + ((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value);
                    (ec.Entities[i])["extendedamount"] = new Money(((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value));
                    service.Update(ec.Entities[i]);
                }

                opp["totallineitemamount"] = new Money(total);

                // Calculate discount based on the total amount
                discount = CalculateDiscount(total);
                total = total - discount;
                opp["discountamount"] = new Money(discount);
                opp["totalamountlessfreight"] = new Money(total);
                service.Update(opp);

                // Calculate tax after the discount is applied
                tax = CalculateTax(total);
                total = total + tax;
                opp["totaltax"] = new Money(tax);
                opp["totalamount"] = new Money(total);
                opp["estimatedvalue"] = new Money(total);
                service.Update(opp);
            }
            return;
        }

        // Method to calculate extended amount in the product line items in an opportunity
        private static void CalculateOpportunityProduct(EntityReference entity, IOrganizationService service)
        {
            try
            {
                ColumnSet columns = new ColumnSet();
                Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("quantity", "priceperunit"));
                decimal total = 0;
                total = total + ((decimal)e["quantity"] * ((Money)e["priceperunit"]).Value);
                e["extendedamount"] = new Money(total);
                service.Update(e);
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }
        
        #endregion

        #region Calculate Quote Price
        // Method to calculate price in a quote
        private static void CalculateQuote(EntityReference entity, IOrganizationService service)
        {
            Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("statecode"));
            OptionSetValue statecode = (OptionSetValue)e["statecode"];
            if (statecode.Value == 0)
            {
                ColumnSet columns = new ColumnSet();
                columns.AddColumns("totaltax", "totallineitemamount", "totalamountlessfreight", "discountamount");
                Entity quote = service.Retrieve(entity.LogicalName, entity.Id, columns);

                QueryExpression query = new QueryExpression("quotedetail");
                query.ColumnSet.AddColumns("quantity", "priceperunit");
                query.Criteria.AddCondition("quoteid", ConditionOperator.Equal, entity.Id);
                EntityCollection ec = service.RetrieveMultiple(query);
                quote["totallineitemamount"] = 0;

                decimal total = 0;
                decimal discount = 0;
                decimal tax = 0;

                for (int i = 0; i < ec.Entities.Count; i++)
                {
                    total = total + ((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value);
                    (ec.Entities[i])["extendedamount"] = new Money(((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value));
                    service.Update(ec.Entities[i]);
                }

                quote["totallineitemamount"] = new Money(total);

                // Calculate discount based on the total amount
                discount = CalculateDiscount(total);
                total = total - discount;
                quote["discountamount"] = new Money(discount);
                quote["totalamountlessfreight"] = new Money(total);
                service.Update(quote);

                // Calculate tax after the discount is applied
                tax = CalculateTax(total);
                total = total + tax;
                quote["totaltax"] = new Money(tax);
                quote["totalamount"] = new Money(total);                
                service.Update(quote);
            }
            return;
        }

        // Method to calculate extended amount in the product line items in a quote
        private static void CalculateQuoteProduct(EntityReference entity, IOrganizationService service)
        {
            try
            {
                ColumnSet columns = new ColumnSet();
                Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("quantity", "priceperunit"));
                decimal total = 0;
                total = total + ((decimal)e["quantity"] * ((Money)e["priceperunit"]).Value);
                e["extendedamount"] = new Money(total);
                service.Update(e);
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }

        #endregion

        #region Calculate Order Price
        // Method to calculate price in an order
        private static void CalculateOrder(EntityReference entity, IOrganizationService service)
        {
            Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("statecode"));
            OptionSetValue statecode = (OptionSetValue)e["statecode"];
            if (statecode.Value == 0)
            {
                ColumnSet columns = new ColumnSet();
                columns.AddColumns("totaltax", "totallineitemamount", "totalamountlessfreight", "discountamount");
                Entity order = service.Retrieve(entity.LogicalName, entity.Id, columns);

                QueryExpression query = new QueryExpression("salesorderdetail");
                query.ColumnSet.AddColumns("quantity", "salesorderispricelocked", "priceperunit");
                query.Criteria.AddCondition("salesorderid", ConditionOperator.Equal, entity.Id);

                QueryExpression query1 = new QueryExpression("salesorderdetail");
                query1.ColumnSet.AddColumns("salesorderispricelocked");
                query1.Criteria.AddCondition("salesorderid", ConditionOperator.Equal, entity.Id);

                EntityCollection ec = service.RetrieveMultiple(query);
                EntityCollection ec1 = service.RetrieveMultiple(query1);
                order["totallineitemamount"] = 0;

                decimal total = 0;
                decimal discount = 0;
                decimal tax = 0;

                for (int i = 0; i < ec.Entities.Count; i++)
                {
                    total = total + ((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value);
                    (ec1.Entities[i])["extendedamount"] = new Money(((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value));
                    service.Update(ec1.Entities[i]);
                }

                order["totallineitemamount"] = new Money(total);

                // Calculate discount based on the total amount
                discount = CalculateDiscount(total);
                total = total - discount;
                order["discountamount"] = new Money(discount);
                order["totalamountlessfreight"] = new Money(total);
                service.Update(order);

                // Calculate tax after the discount is applied
                tax = CalculateTax(total);
                total = total + tax;
                order["totaltax"] = new Money(tax);
                order["totalamount"] = new Money(total);                
                service.Update(order);
            }
            return;
        }

        // Method to calculate extended amount in the product line items in a order
        private static void CalculateOrderProduct(EntityReference entity, IOrganizationService service)
        {
            try
            {
                ColumnSet columns = new ColumnSet();
                Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("quantity", "priceperunit", "salesorderispricelocked"));
                Entity e1 = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("quantity", "salesorderispricelocked"));
                decimal total = 0;
                total = total + ((decimal)e["quantity"] * ((Money)e["priceperunit"]).Value);
                e1["extendedamount"] = new Money(total);
                service.Update(e1);
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }

        #endregion

        #region Calculate Invoice Price
        // Method to calculate price in an invoice
        private static void CalculateInvoice(EntityReference entity, IOrganizationService service)
        {
            Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("statecode"));
            OptionSetValue statecode = (OptionSetValue)e["statecode"];
            if (statecode.Value == 0)
            {
                ColumnSet columns = new ColumnSet();
                columns.AddColumns("totaltax", "totallineitemamount", "totalamountlessfreight", "discountamount");

                Entity invoice = service.Retrieve(entity.LogicalName, entity.Id, columns);

                QueryExpression query = new QueryExpression("invoicedetail");
                query.ColumnSet.AddColumns("quantity", "invoiceispricelocked", "priceperunit");
                query.Criteria.AddCondition("invoiceid", ConditionOperator.Equal, entity.Id);

                QueryExpression query1 = new QueryExpression("invoicedetail");
                query1.ColumnSet.AddColumns("quantity", "invoiceispricelocked");
                query1.Criteria.AddCondition("invoiceid", ConditionOperator.Equal, entity.Id);

                EntityCollection ec = service.RetrieveMultiple(query);
                EntityCollection ec1 = service.RetrieveMultiple(query1);
                
                invoice["totallineitemamount"] = 0;

                decimal total = 0;
                decimal discount = 0;
                decimal tax = 0;

                for (int i = 0; i < ec.Entities.Count; i++)
                {
                    total = total + ((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value);
                    (ec1.Entities[i])["extendedamount"] = new Money(((decimal)ec.Entities[i]["quantity"] * ((Money)ec.Entities[i]["priceperunit"]).Value));
                    service.Update(ec1.Entities[i]);
                }

                invoice["totallineitemamount"] = new Money(total);

                // Calculate discount based on the total amount
                discount = CalculateDiscount(total);
                total = total - discount;
                invoice["discountamount"] = new Money(discount);
                invoice["totalamountlessfreight"] = new Money(total);
                service.Update(invoice);

                // Calculate tax after the discount is applied
                tax = CalculateTax(total);
                total = total + tax;
                invoice["totaltax"] = new Money(tax);
                invoice["totalamount"] = new Money(total);                
                service.Update(invoice);
            }
            return;
        }        

        // Method to calculate extended amount in the product line items in an invoice
        private static void CalculateInvoiceProduct(EntityReference entity, IOrganizationService service)
        {
            try
            {
                ColumnSet columns = new ColumnSet();
                Entity e = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("quantity", "priceperunit", "invoiceispricelocked"));
                Entity e1 = service.Retrieve(entity.LogicalName, entity.Id, new ColumnSet("quantity", "invoiceispricelocked"));
                decimal total = 0;
                total = total + ((decimal)e["quantity"] * ((Money)e["priceperunit"]).Value);
                e1["extendedamount"] = new Money(total);
                service.Update(e1);
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }

        #endregion


        // Method to calculate discount.
        private static decimal CalculateDiscount(decimal amount)
        {
            decimal discount = 0;

            if (amount > (decimal)1000.00 && amount < (decimal)5000.00)
            {
                discount = amount * (decimal)0.05;
            }
            else if (amount >= (decimal)5000.00)
            {
                discount = amount * (decimal)0.10;
            }
            return discount;
        }

        // Method to calculate tax.        
        private static decimal CalculateTax(decimal amount)
        {
            decimal tax = 0;
            if (amount < (decimal)5000.00)
            {
                tax = amount * (decimal)0.10;
            }
            else 
            {
                tax = amount * (decimal)0.08;
            }
            return tax;
        }  
    }
}

// </snippetcalculatepriceplugin>