// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CommunicationsOperations operations.
    /// </summary>
    public partial interface ICommunicationsOperations
    {
        /// <summary>
        /// Check the availability of a resource name. This API should to be
        /// used to check the uniqueness of the name for adding a new
        /// communication to the support ticket.
        /// </summary>
        /// <param name='supportTicketName'>
        /// Support ticket name
        /// </param>
        /// <param name='checkNameAvailabilityInput'>
        /// Input to check
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckNameAvailabilityOutput>> CheckNameAvailabilityWithHttpMessagesAsync(string supportTicketName, CheckNameAvailabilityInput checkNameAvailabilityInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all communications (attachments not included) for a support
        /// ticket. &lt;br/&gt;&lt;/br&gt; You can also filter support ticket
        /// communications by &lt;i&gt;CreatedDate&lt;/i&gt;�or
        /// &lt;i&gt;CommunicationType&lt;/i&gt; using the $filter parameter.
        /// The only type of communication supported today is
        /// &lt;i&gt;Web&lt;/i&gt;. Output will be a paged result with
        /// &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next
        /// set of Communication results. &lt;br/&gt;&lt;br/&gt; Support ticket
        /// data is available for 12 months after ticket creation. If a ticket
        /// was created more than 12 months ago, a request for data might cause
        /// an error.
        /// </summary>
        /// <param name='supportTicketName'>
        /// Support ticket name
        /// </param>
        /// <param name='top'>
        /// The number of values to return in the collection. Default is 10 and
        /// max is 10.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation. You can filter by
        /// communicationType and createdDate properties. CommunicationType
        /// supports Equals ('eq') operator and createdDate supports Greater
        /// Than ('gt') and Greater Than or Equals ('ge') operators. You may
        /// combine the CommunicationType and CreatedDate filters by Logical
        /// And ('and') operator.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CommunicationDetails>>> ListWithHttpMessagesAsync(string supportTicketName, int? top = default(int?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns details of a specific communication in a support ticket.
        /// </summary>
        /// <param name='supportTicketName'>
        /// Support ticket name
        /// </param>
        /// <param name='communicationName'>
        /// Communication name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CommunicationDetails>> GetWithHttpMessagesAsync(string supportTicketName, string communicationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a new customer communication to an Azure support ticket.
        /// Adding attachments are not currently supported via the API.
        /// &lt;br/&gt;To add a file to a support ticket, visit the &lt;a
        /// target='_blank'
        /// href='https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest'&gt;Manage
        /// support ticket&lt;/a&gt; page in the Azure portal, select the
        /// support ticket, and use the file upload control to add a new file.
        /// </summary>
        /// <param name='supportTicketName'>
        /// Support ticket name
        /// </param>
        /// <param name='communicationName'>
        /// Communication name
        /// </param>
        /// <param name='createCommunicationParameters'>
        /// Communication object
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CommunicationDetails>> CreateWithHttpMessagesAsync(string supportTicketName, string communicationName, CommunicationDetails createCommunicationParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a new customer communication to an Azure support ticket.
        /// Adding attachments are not currently supported via the API.
        /// &lt;br/&gt;To add a file to a support ticket, visit the &lt;a
        /// target='_blank'
        /// href='https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest'&gt;Manage
        /// support ticket&lt;/a&gt; page in the Azure portal, select the
        /// support ticket, and use the file upload control to add a new file.
        /// </summary>
        /// <param name='supportTicketName'>
        /// Support ticket name
        /// </param>
        /// <param name='communicationName'>
        /// Communication name
        /// </param>
        /// <param name='createCommunicationParameters'>
        /// Communication object
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CommunicationDetails>> BeginCreateWithHttpMessagesAsync(string supportTicketName, string communicationName, CommunicationDetails createCommunicationParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all communications (attachments not included) for a support
        /// ticket. &lt;br/&gt;&lt;/br&gt; You can also filter support ticket
        /// communications by &lt;i&gt;CreatedDate&lt;/i&gt;�or
        /// &lt;i&gt;CommunicationType&lt;/i&gt; using the $filter parameter.
        /// The only type of communication supported today is
        /// &lt;i&gt;Web&lt;/i&gt;. Output will be a paged result with
        /// &lt;i&gt;nextLink&lt;/i&gt;, using which you can retrieve the next
        /// set of Communication results. &lt;br/&gt;&lt;br/&gt; Support ticket
        /// data is available for 12 months after ticket creation. If a ticket
        /// was created more than 12 months ago, a request for data might cause
        /// an error.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CommunicationDetails>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
