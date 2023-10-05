namespace Hash_Table
{
     class UC1_2_3
    {
        private readonly int bucketCount;
        private readonly LinkedList<MyMapNode<string, int>>[] hashTable;

        public UC1_2_3(int bucketCount)
        {
            this.bucketCount = bucketCount;
            hashTable = new LinkedList<MyMapNode<string, int>>[bucketCount];
            for (int i = 0; i < bucketCount; i++)
            {
                hashTable[i] = new LinkedList<MyMapNode<string, int>>();
            }
        }       
        private int GetBucketIndex(string word)
        {
            int hash = word.GetHashCode();
            return Math.Abs(hash) % bucketCount;
        }

        
        public void AddWord(string word)
        {
            int bucketIndex = GetBucketIndex(word);

            foreach (var node in hashTable[bucketIndex])
            {
                if (node.Key == word)
                {
                    node.Value++;
                    return;
                }
            }

            var newNode = new MyMapNode<string, int>(word, 1);
            hashTable[bucketIndex].AddLast(newNode);
        }
        public void RemoveWord(string word)
        {
            int bucketIndex = GetBucketIndex(word);

            LinkedListNode<MyMapNode<string, int>> nodeToRemove = null;

            foreach (var node in hashTable[bucketIndex])
            {
                if (node.Key == word)
                {
                   
                    break;
                }
            }

            if (nodeToRemove != null)
            {
                hashTable[bucketIndex].Remove(nodeToRemove);
            }
        }


      
        public int GetWordFrequency(string word)
        {
            int bucketIndex = GetBucketIndex(word);

            foreach (var node in hashTable[bucketIndex])
            {
                if (node.Key == word)
                {
                    return node.Value;
                }
            }


            // Word not found in the hash table
            return 0;
        }
    }
}