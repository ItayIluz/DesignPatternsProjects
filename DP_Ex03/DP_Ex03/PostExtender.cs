using FacebookWrapper.ObjectModel;

namespace DP_Ex03
{
    public class PostExtender : IPostExtender
    {
        public IPostExtender ExtraPostExtender { get; }

        public PostExtender(IPostExtender i_PostExtender)
        {
            ExtraPostExtender = i_PostExtender;
        }

        public virtual void updateDataToServer()
        {
            ExtraPostExtender.updateDataToServer();
        }

        public Post GetCorePost()
        {
            IPostExtender currentPostExtender = ExtraPostExtender as PostExtender;
            Post postToReturn = null;

            while(currentPostExtender is PostExtender)
            {
                currentPostExtender = (currentPostExtender as PostExtender).ExtraPostExtender;
            }

            if(currentPostExtender is CoreExtendedPost)
            {
                CoreExtendedPost coreExtendedPost = currentPostExtender as CoreExtendedPost;
                postToReturn = coreExtendedPost.Post;
            }

            return postToReturn;
        }
    }
}
