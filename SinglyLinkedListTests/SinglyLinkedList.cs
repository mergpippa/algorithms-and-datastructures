﻿using Xunit;

namespace SinglyLinkedListTests
{
    public class Tests
    {
        [Fact]
        public void Should_ReturnTrue_When_SinglyLinkedListIsEmpty()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            Assert.True(singlyLinkedList.IsEmpty());
        }

        [Fact]
        public void Should_HaveHeadNode()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            Assert.True(singlyLinkedList.Zeroth().Retrieve() == null);
        }

        [Fact]
        public void Should_InsertANode()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Add new node after the head node
            singlyLinkedList.Insert(5, singlyLinkedList.Zeroth());

            Assert.True((int) singlyLinkedList.First().Retrieve() == 5);
        }
        
        [Fact]
        public void Should_RemoveANode()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Add new node after the head node
            singlyLinkedList.Insert(5, singlyLinkedList.Zeroth());

            Assert.True((int) singlyLinkedList.First().Retrieve() == 5);
        }

        [Fact]
        public void Should_BeEmpty_When_EmptyingList()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            // Add new node after the head node
            singlyLinkedList.Insert(5, singlyLinkedList.Zeroth());

            // Empty list
            singlyLinkedList.MakeEmpty();

            Assert.True(singlyLinkedList.First().Retrieve() == null);
        }

        [Fact]
        public void Should_FindNodeMatchingGivenData()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            const int data = 2;

            // Add new node after the head node
            singlyLinkedList.Insert(3, singlyLinkedList.Zeroth());
            singlyLinkedList.Insert(data, singlyLinkedList.Zeroth());
            singlyLinkedList.Insert(1, singlyLinkedList.Zeroth());

            Assert.True((int) singlyLinkedList.Find(data).Retrieve() == data);
        }

        [Fact]
        public void Should_FindNodePriorToNodeMatchingGivenData()
        {
            var singlyLinkedList = new SinglyLinkedList.SinglyLinkedList();

            const int data = 2;
            const int prior = 1;

            // Add new node after the head node
            singlyLinkedList.Insert(3, singlyLinkedList.Zeroth());
            singlyLinkedList.Insert(data, singlyLinkedList.Zeroth());
            singlyLinkedList.Insert(prior, singlyLinkedList.Zeroth());
            
            singlyLinkedList.Print();

            Assert.True((int) singlyLinkedList.FindPrevious(data).Retrieve() == prior);
        }
    }
}