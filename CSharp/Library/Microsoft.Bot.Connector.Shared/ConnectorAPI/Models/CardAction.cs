// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A clickable action
    /// </summary>
    public partial class CardAction
    {
        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        public CardAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        /// <param name="type">The type of action implemented by this button.
        /// Possible values include: 'openUrl', 'imBack', 'postBack',
        /// 'playAudio', 'playVideo', 'showImage', 'downloadFile', 'signin',
        /// 'call', 'payment', 'messageBack'</param>
        /// <param name="title">Text description which appears on the
        /// button</param>
        /// <param name="image">Image URL which will appear on the button, next
        /// to text label</param>
        /// <param name="text">Text for this action</param>
        /// <param name="displayText">(Optional) text to display in the chat
        /// feed if the button is clicked</param>
        /// <param name="value">Supplementary parameter for action. Content of
        /// this property depends on the ActionType</param>
        /// <param name="channelData">Channel-specific data associated with
        /// this action</param>
        public CardAction(string type = default(string), string title = default(string), string image = default(string), object value = default(object), string text = default(string), string displayText = default(string), object channelData = default(object))
        {
            Type = type;
            Title = title;
            Image = image;
            Text = text;
            DisplayText = displayText;
            Value = value;
            ChannelData = channelData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of action implemented by this button.
        /// Possible values include: 'openUrl', 'imBack', 'postBack',
        /// 'playAudio', 'playVideo', 'showImage', 'downloadFile', 'signin',
        /// 'call', 'payment', 'messageBack'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets text description which appears on the button
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets image URL which will appear on the button, next to
        /// text label
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets text for this action
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets (Optional) text to display in the chat feed if the
        /// button is clicked
        /// </summary>
        [JsonProperty(PropertyName = "displayText")]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or sets supplementary parameter for action. Content of this
        /// property depends on the ActionType
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets channel-specific data associated with this action
        /// </summary>
        [JsonProperty(PropertyName = "channelData")]
        public object ChannelData { get; set; }

    }
}
