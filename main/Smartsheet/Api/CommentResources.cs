﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed To in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

namespace Smartsheet.Api
{
	using Comment = Api.Models.Comment;

	/// <summary>
	/// <para>This interface provides methods To access Comment resources.</para>
	/// 
	/// <para>Thread Safety: Implementation of this interface must be thread safe.</para>
	/// </summary>
	public interface CommentResources
	{

		/// <summary>
		/// <para>Get a Comment.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method:<br />
		/// GET /Comment/{Id}</para>
		/// </summary>
		/// <param name="id"> the Id </param>
		/// <returns> the Comment (note that if there is no such resource, this method will throw ResourceNotFoundException
		/// rather than returning null). </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Comment GetComment(long id);

		/// <summary>
		/// <para>Delete a Comment.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method:<br />
		/// DELETE /Comment{Id}</para>
		/// </summary>
		/// <param name="id"> the Id </param>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void DeleteComment(long id);

		/// <summary>
		/// <para>Return the AssociatedAttachmentResources object that provides access To attachment resources associated with
		/// Comment resources.</para>
		/// </summary>
		/// <returns> the associated attachment resources </returns>
		AssociatedAttachmentResources Attachments();
	}

}