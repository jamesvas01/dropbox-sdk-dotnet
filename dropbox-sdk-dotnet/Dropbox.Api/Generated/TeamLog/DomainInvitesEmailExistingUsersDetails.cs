// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Sent domain invites to existing domain accounts.</para>
    /// </summary>
    public class DomainInvitesEmailExistingUsersDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DomainInvitesEmailExistingUsersDetails> Encoder = new DomainInvitesEmailExistingUsersDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DomainInvitesEmailExistingUsersDetails> Decoder = new DomainInvitesEmailExistingUsersDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainInvitesEmailExistingUsersDetails" /> class.</para>
        /// </summary>
        /// <param name="domainName">Domain names.</param>
        /// <param name="numRecipients">Number of recipients.</param>
        public DomainInvitesEmailExistingUsersDetails(string domainName,
                                                      ulong numRecipients)
        {
            if (domainName == null)
            {
                throw new sys.ArgumentNullException("domainName");
            }

            this.DomainName = domainName;
            this.NumRecipients = numRecipients;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainInvitesEmailExistingUsersDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DomainInvitesEmailExistingUsersDetails()
        {
        }

        /// <summary>
        /// <para>Domain names.</para>
        /// </summary>
        public string DomainName { get; protected set; }

        /// <summary>
        /// <para>Number of recipients.</para>
        /// </summary>
        public ulong NumRecipients { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DomainInvitesEmailExistingUsersDetails" />.</para>
        /// </summary>
        private class DomainInvitesEmailExistingUsersDetailsEncoder : enc.StructEncoder<DomainInvitesEmailExistingUsersDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DomainInvitesEmailExistingUsersDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("domain_name", value.DomainName, writer, enc.StringEncoder.Instance);
                WriteProperty("num_recipients", value.NumRecipients, writer, enc.UInt64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DomainInvitesEmailExistingUsersDetails" />.</para>
        /// </summary>
        private class DomainInvitesEmailExistingUsersDetailsDecoder : enc.StructDecoder<DomainInvitesEmailExistingUsersDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DomainInvitesEmailExistingUsersDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DomainInvitesEmailExistingUsersDetails Create()
            {
                return new DomainInvitesEmailExistingUsersDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DomainInvitesEmailExistingUsersDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "domain_name":
                        value.DomainName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "num_recipients":
                        value.NumRecipients = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
