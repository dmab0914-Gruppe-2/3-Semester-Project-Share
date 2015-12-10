using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using Server;
namespace UnitTestProject
{
    [TestClass]
    public class FileChat42Test
    {
        IChatController chatController = new ChatController();
        IUserController userController = new UserController();
        IFileController fileController = new FileController();
        private User myUser;
        private File myFile;

        [TestInitialize]
        public void Setup()
        {
            myUser = userController.FindUserById(5);
            myFile = fileController.GetFile(1);

            if (!myUser.Username.Equals("arm")) 
            { 
                Assert.Fail("Something went wrong when downloading user: arm");
            }

            if (!myFile.Title.Equals("my file")) 
            { 
                Assert.Fail("Something went wrong when downloading file");
            }
        }

        [TestMethod]
        public void SendMessageTest()
        {
            ChatMessage chatMessage = new ChatMessage("fedt arbejde", myUser);
            bool success = chatController.SendMessage(chatMessage, myFile);
            Assert.IsTrue(success);


        }
    }
}
