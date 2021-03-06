﻿using System;
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
        public void TestSendMessageSuccess()
        {
            ChatMessage chatMessage = new ChatMessage("fedt arbejde", myUser);
            bool success = chatController.SendMessage(chatMessage, myFile);
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void TestSendMessageFailUser()
        {
            ChatMessage chatMessage = new ChatMessage("fedt arbejde", null);
            bool success = chatController.SendMessage(chatMessage, myFile);
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void TestSendMessageFailEmptyMessage()
        {
            ChatMessage chatMessage = new ChatMessage("", myUser);
            bool success = chatController.SendMessage(chatMessage, myFile);
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void TestGet20MessagesSuccess()
        {
            ChatMessage chatMessage = new ChatMessage("fedt lavet", myUser);
            chatController.SendMessage(chatMessage, myFile);
            List<ChatMessage> messages = chatController.GetLast20MessagesFromFile(myFile);
            Assert.IsNotNull(messages);
        }

        [TestMethod]
        public void TestGet20MessagesFailFileId()
        {
            ChatMessage chatMessage = new ChatMessage("fedt lavet", myUser);
            chatController.SendMessage(chatMessage, myFile);
            List<ChatMessage> messages = chatController.GetLast20MessagesFromFile(null);
            Assert.IsNull(messages);
            
        }
    }
}
