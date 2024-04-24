using UnityEngine;

public class RopeSpawner : MonoBehaviour{
    public RopeNode nodePrefab;
    public int nodesCount;
    public LineRenderer lr;
    
    public RopeNode[] nodes;
    
    
    private void Start(){
        nodes = new RopeNode[nodesCount];
        
        nodes[0] = Instantiate(nodePrefab, transform.position, Quaternion.identity);
        nodes[0].rb.isKinematic = true;
        
        lr.positionCount = nodesCount;
        
        for (int i = 1; i < nodesCount; i++){
            nodes[i] = Instantiate(nodePrefab, transform.position - Vector3.up * i * nodes[i-1].transform.localScale.y, Quaternion.identity);
            nodes[i].spring.connectedBody = nodes[i-1].rb;
        }
    }
    
    private void Update(){
        for (int i = 0; i < nodesCount; i++){
            lr.SetPosition(i, nodes[i].transform.position);
        }
    }
}
