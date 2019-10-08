using System;
using System.Collections.Generic;
using System.Text;

namespace behavior_design_patterns.ChainOfResponsibility
{
    public abstract class PacketProcessor
    {
        protected TCPIPLayer currentLayer;

        protected PacketProcessor nextProcessor;

        public PacketProcessor SetNext(PacketProcessor next)
        {
            nextProcessor = next;
            return this;
        }

        protected abstract string _addPacketHeader(string packet);

        public string ProcessPacket(string packet, TCPIPLayer startingLayer)
        {            
            string processedPacket = packet;
            if(currentLayer <= startingLayer)
            {
                Console.WriteLine($"Processing At Layer {Enum.GetName(typeof(TCPIPLayer), currentLayer)}");
                Console.WriteLine($"input packet: {packet}");
                processedPacket = _addPacketHeader(packet);
                Console.WriteLine($"output packet: {processedPacket}");
                Console.WriteLine();
            }
            if(nextProcessor != null)
            {
                return nextProcessor.ProcessPacket(processedPacket, startingLayer);
            }
            
            return processedPacket;
        }
    }

    public class PhysicalProcessor : PacketProcessor
    {
        public PhysicalProcessor()
            : base()
        {
            currentLayer = TCPIPLayer.Physical;
        }
        
        protected override string _addPacketHeader(string packet)
        {
            return "Physical_Address|" + packet;
        }
    }

    public class LinkProcessor : PacketProcessor
    {
        public LinkProcessor()
            : base()
        {
            currentLayer = TCPIPLayer.Link;
        }

        protected override string _addPacketHeader(string packet)
        {
            return "Link_Address|" + packet;
        }
    }

    public class InternetProcessor : PacketProcessor
    {
        public InternetProcessor()
            : base()
        {
            currentLayer = TCPIPLayer.Internet;
        }

        protected override string _addPacketHeader(string packet)
        {
            return "Internet_Address|" + packet;
        }
    }

    public class TransportProcessor : PacketProcessor
    {
        public TransportProcessor()
            : base()
        {
            currentLayer = TCPIPLayer.Transport;
        }

        protected override string _addPacketHeader(string packet)
        {
            return "Transport_Address|" + packet;
        }
    }

    public class ApplicationProcessor : PacketProcessor
    {
        public ApplicationProcessor()
            : base()
        {
            currentLayer = TCPIPLayer.Application;
        }

        protected override string _addPacketHeader(string packet)
        {
            return "Application_Address|" + packet;
        }
    }

    public class ChainOfResponsibilityDemo
    {
        public void DemoProcessing()
        {
            string packet = "[xxx-data-xxx]";
            PacketProcessor packetProcessor = new ApplicationProcessor()
                .SetNext(new TransportProcessor()
                .SetNext(new InternetProcessor()
                .SetNext(new LinkProcessor()
                .SetNext(new PhysicalProcessor()))));

            //Process at Link Layer
            Console.WriteLine("Process at Link Layer");
            packetProcessor.ProcessPacket(packet, TCPIPLayer.Link);

            //Process at Transport Layer
            Console.WriteLine("Process at Transport Layer");
            packetProcessor.ProcessPacket(packet, TCPIPLayer.Transport);

            //Process at Application Layer
            Console.WriteLine("Process at Application Layer");
            packetProcessor.ProcessPacket(packet, TCPIPLayer.Application);


        }
    }

    public enum TCPIPLayer
    {
        Physical = 1,
        Link = 2,
        Internet = 3,
        Transport = 4,
        Application = 5
    }
}
